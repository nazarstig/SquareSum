using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SquareSum
{
    class ComponentsOfSumOfSquares
    {
        List<double> _inputNumbers;
        List<double> _outputNumbers = new List<double>();
        int _numberOfOutputNumbers = 4;
        bool _canGetOutputNumbers;
        double _squaresSum;


        public List<double> InputNumbers
        {
            get { return _inputNumbers; }
            set { _inputNumbers = value; }
        }

        public List<double> OutputNumbers
        {
            get { return _outputNumbers; }
            set { _outputNumbers = value; }
        }

        public int NumberOfOutputNumbers
        {
            get { return _numberOfOutputNumbers; }
            set { _numberOfOutputNumbers = value; }
        }

        public double SquaresSum
        {
            get { return _squaresSum; }
        }

        public bool CanGetOutputNumbers
        {
            get { return _canGetOutputNumbers; }
        }

        public ComponentsOfSumOfSquares(List<double> inputNumbers)
        {
            InputNumbers = inputNumbers;
            _squaresSum = CountSquaresSum(InputNumbers);
            _canGetOutputNumbers = FindOutputNumbers(this);
        }

        public double CountSquaresSum(List<double> numbers)
        {
            List<double> squareOfNumbers = new List<double>();
            foreach(double number in InputNumbers)
            {
                squareOfNumbers.Add(Math.Pow(number, 2));
            }
            return squareOfNumbers.Sum();
        }

        public bool GetRootOfNumber(out int result, double sum)
        {
            try
            {
                result = (int)(Math.Pow(sum, 0.5));
            }
            catch (Exception)
            {
                result = -1;
                return false;
            }
            return true;
        }


        public bool FindOutputNumbers(ComponentsOfSumOfSquares components)
        {
            int number;
            double sum = components.SquaresSum;
            int i = 0;
            while ( !ComponentsFounded(sum) && !DeterminedThatCannotGetComponents(i))
            {
               CountNumbers(ref i, ref sum);
            }

            if (ComponentsFounded(sum)) return true;
            else return false;
        }

        public void CountNumbers(ref int i, ref double sum)
        {
            int outputNumber = FindOutputNumber(ref sum);
            AddingOutputNumberAndReecountSum(ref outputNumber, ref sum);
           // Helper.OutputCollection(OutputNumbers);
        }

       public void AddingOutputNumberAndReecountSum(ref int outputNumber, ref double sum)
       {
            if (CheckIfOutputNumberIsCorrect(outputNumber))
            {
                OutputNumbers.Add(outputNumber);
                CountSum(ref outputNumber, ref sum);
                //Console.WriteLine("sum = " + sum);
            }
          
       }

        public void CountSum(ref int outputNumber, ref double sum)
        {
            sum -= Math.Pow(outputNumber, 2);
        }

        public bool ComponentsFounded(double sum)
        {
            if (sum == 0 && OutputNumbers.Count == NumberOfOutputNumbers) return true;
            else return false;
        }

        public bool DeterminedThatCannotGetComponents(int i)
        {
            if (OutputNumbers.Contains(-1)) return true;
            else return false;
        }

        public int FindOutputNumber(ref double sum)
        {
            int outputNumber;

            if (sum > 0 && OutputNumbers.Count < NumberOfOutputNumbers)
            {

                GetRootOfNumber(out outputNumber, sum);
            }

            else if (sum > 0)
            {
                EnumeratePreviousNumberWhenAllMembersFound(out outputNumber, ref sum);
            }

            else if (sum == 0)
            {
                EnumeratePreviousNumber(out outputNumber, ref sum);
            }


            else outputNumber = 0;
           return outputNumber;
        }

        public void EnumeratePreviousNumberWhenAllMembersFound(out int outputNumber, ref double sum)
        {
            sum += Math.Pow(OutputNumbers.LastOrDefault(), 2);
            RemoveLastElement();
            EnumeratePreviousNumber(out outputNumber, ref sum);

        }

        public bool CheckIfOutputNumberIsCorrect(int outputNumber)
        {
            if (outputNumber >= 1 || outputNumber == -1) return true;
            else return false;
        }

        public double FindNewValueOfSum(double outputNumber, ref double sum)
        {
            sum -= Math.Pow(outputNumber, 2);
          //  Console.WriteLine("sum = " + sum);
            return sum;
        }

        public bool FindAndCheckNewValueOfSum(double outputNumber, ref double sum)
        {
            if (FindNewValueOfSum(outputNumber, ref sum) > 0)
                return true;
            else return false;
        }

        public void RemoveLastElement()
        {
            OutputNumbers.RemoveAt(OutputNumbers.Count - 1);
        }

        public void EnumeratePreviousNumber(out int outputNumber, ref double sum)
        {
                
                int lastOutputNumber = (int)OutputNumbers.LastOrDefault();
                RemoveLastElement();
                sum += Math.Pow(lastOutputNumber, 2);
                outputNumber = lastOutputNumber - 1;

                if (!CheckIfOutputNumberIsCorrect(outputNumber) && OutputNumbers.Count == 0)
                {
                       
                       outputNumber = -1;
                       
                }
                
                else if(!CheckIfOutputNumberIsCorrect(outputNumber))
                {
                       EnumeratePreviousNumber(out outputNumber, ref sum);
                }       
                
        }

    }
}
