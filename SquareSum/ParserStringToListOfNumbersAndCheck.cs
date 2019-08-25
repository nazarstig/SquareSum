using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SquareSum
{
    class ParserStringToListOfNumbersAndCheckForTaskCondition : ParserStringToListOfNumbers
    {
        bool _satisfyConditions;
        double _lowerMeasure = 1;
        double _upperMeasure = Math.Pow(10 , 9);
        double _listCount = 3;
        string _warning;

        public double LowerMeasure
        {
            get { return _lowerMeasure; }
            set { _lowerMeasure = value; }
        }

        public double ListCount
        {
            get { return _listCount; }
            set { _listCount = value; }
        }

        public double UpperMeasure
        {
            get { return _upperMeasure; }
            set { _upperMeasure = value; }
        }

        public bool SatisfyConditions
        {
            get { return _satisfyConditions; }
        }

        public string Warning
        {
            get { return _warning; }
            set { _warning = value; }
        }

        public ParserStringToListOfNumbersAndCheckForTaskCondition(string input) : base(input)
        {
            _satisfyConditions = CheckConditions(Numbers);
        }

        public ParserStringToListOfNumbersAndCheckForTaskCondition(string input, string splitter) : base(input, splitter)
        {
            _satisfyConditions = CheckConditions(Numbers);
        }

        public bool CheckConditions(List<double> numbers)
        {
            if (CanParseToNumbersList
                && CheckIfNumbersCountSatisfyCondition(numbers)
                && CheckIfNumbersInListInMeasurements(numbers)
                && CheckIfNumbersInListIsPair(numbers)
                && CheckIfNumbersFormTriange(numbers))
                return true;

           else return false;
        }

        public bool CheckIfNumbersInListIsPair(List<double> numbers)
        {
            foreach(double number in numbers)
            {
                if (!CheckIfNumberIsPair(number)) return false;
            }
            return true;
        }

        public bool CheckIfNumbersInListInMeasurements(List<double> numbers)
        {
            foreach (double number in numbers)
            {
                if ( !CheckIfNumberInMeasurements (number)) return false;
            }
            return true;
        }


        public bool CheckIfNumberIsPair(double number)
        {
            if (number % 2 == 0) return true;
            else
            {
                Warning = Helper.PairNumbersWarning;
                return false;
            }
        }

        public bool CheckIfNumberInMeasurements(double number)
        {
            if (number >= LowerMeasure && number <= UpperMeasure) return true;
            else
            {
                Warning = Helper.NumberInMeasurementsWarning;
                return false;
            };
        }

        public bool CheckIfNumbersCountSatisfyCondition(List<double> numbers)
        {
            if (numbers.Count == ListCount) return true;
            else return false;
        }

        public bool CheckIfNumbersFormTriange(List<double> numbers)
        {
            foreach (double number in numbers)
            {
                if (number > (numbers.Sum() - number))
                {
                    Warning = Helper.TriangleInequalityWarning;
                    return false;
                }
            }
            return true;
        }
    }
}
