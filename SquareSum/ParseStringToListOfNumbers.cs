using System;
using System.Collections.Generic;
using System.Text;

namespace SquareSum
{
    class ParserStringToListOfNumbers : ParserStringToListOfElements
    {
        bool _canParseToNumbersList;
        List<double> _numbers;

        public List<double> Numbers
        {
            get { return _numbers; }
            set { _numbers = value; }
        }

        public bool CanParseToNumbersList
        {
            get { return _canParseToNumbersList; }
        }

        public ParserStringToListOfNumbers (string input) : base(input)
        {
            _canParseToNumbersList = ParseStringListToDoubleList(out _numbers, Elements);
        }

        public ParserStringToListOfNumbers(string input, string splitter) : base(input, splitter)
        {
            _canParseToNumbersList = ParseStringListToDoubleList(out _numbers, Elements);
        }

        public bool ParseStringToDouble(out double number, string str)
        {
            bool canParseStringToInt = true;
            try
            {
                number = double.Parse(str);
            }
            catch (Exception)
            {
                canParseStringToInt = false;
                number = 0;
            }
            return canParseStringToInt;
        }

        public bool ParseStringListToDoubleList(out List<double> numbersDouble, List<string> strings)
        {
            numbersDouble = new List<double>();
            double number;
            foreach (string str in strings)
            {
                if (ParseStringToDouble(out number, str))
                    numbersDouble.Add(number);
                else
                {
                    numbersDouble = new List<double>();
                    return false;
                }
            }
            return true;
        }
    }
}
