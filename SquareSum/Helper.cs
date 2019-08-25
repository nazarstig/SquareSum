using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SquareSum
{
    class Helper
    {
        static public bool CheckInputOfThreeSidesOfTriangle()
        {
            return false;
        }

        static public string TriangleInequalityWarning = "This numbers doesn't satisfy triangle inequality";
        static public string PairNumbersWarning = "There is at least one unpair number";
        static public string NumberInMeasurementsWarning = "There is at least one number that is not contained in measurements";


        static public void OutputCollection(List<double> collection )
        {
            foreach (double element in collection)
                Console.Write(element + "  ");
            Console.WriteLine();
        }

        static public List<string> ParseStringToStringList(string input)
        {
            List<string> strings = input.Split(' ').ToList();
            return strings;
        }

        //static public List<int> ParseStringToListOfNumbers(string input)
        //{
        //    List<string> numbers = ParseStringToStringList(input);
        //    List<int> numbersInt = ParseStringCollectionToIntList(numbers);
        //    return numbersInt;
        //}

        static public bool ParseStringToInt(out int number, string str)
        {
            bool canParseStringToInt = true;
            try
            {
                number = int.Parse(str);
            }
            catch(Exception)
            {
                canParseStringToInt = false;
                number = 0;
            }
            return canParseStringToInt;
        }

        static public bool ParseStringListToIntList(out List<int>numbersInt, List<string> strings)
        {
            numbersInt = new List<int>();
            int number;
            foreach (string str in strings)
            {
                if (ParseStringToInt(out number, str))
                    numbersInt.Add(number);
                else
                {
                    numbersInt = null;                    
                    return false;
                }
            }
            return true;
        }
    }
}
