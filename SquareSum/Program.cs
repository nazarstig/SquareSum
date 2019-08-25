using System;
using System.Collections.Generic;
using System.Linq;
namespace SquareSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int T;
            T = Console.Read();
            for(int i = 0; i < T; ++i)
            {
                input = Console.ReadLine();
              
                ParserStringToListOfNumbersAndCheckForTaskCondition parser = new ParserStringToListOfNumbersAndCheckForTaskCondition(input);
                if (parser.SatisfyConditions)
                {
                    ComponentsOfSumOfSquares components = new ComponentsOfSumOfSquares(parser.Numbers);
                    Helper.OutputCollection(components.OutputNumbers);
                }
                else
                {
                    Console.WriteLine(parser.Warning);
                }
            }
        }
    }

}

