using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SquareSum
{
    class ParserStringToListOfElements
    {
        string _splitter = " ";
        string _input;
        bool _canParseToStringList;
        List<string> _elements;

        //accessors
        public string Splitter
        {
            get { return _splitter; }
            set { _splitter = value; }
        }

       
        
        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        public List<string> Elements
        {
            get { return _elements; }
            set { _elements = value; }
        }

        public bool CanParseToStringList
        {
            get { return _canParseToStringList; }
        }
        //constructors
        public ParserStringToListOfElements(string input)
        {
            Input = input;
            _canParseToStringList = ParseStringToStringList(out _elements);
        }

        public ParserStringToListOfElements(string input, string splitter)
        {
            Input = input;
            Splitter = splitter;
            _canParseToStringList = ParseStringToStringList(out _elements);
        }


        //parsing string to list
        public bool ParseStringToStringList(out List<string> Elements)
        {
            try
            {
                Elements = Input.Split(Splitter).ToList();
            }
            catch(Exception)
            {
                Elements = new List<string>();
                return false;
            }
            return true;
        }
    }
}
