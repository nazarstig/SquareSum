//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SquareSum
//{
//    class CounterOfComponents
//    {
//        private double _squaresSum;
//        private int _outputNumbersAmount;
//        private double[] _outputNumbers ;

//        private bool _canGetNaturalComponents;

//        private int _iterator ;
//        private int _iteratorInFinish;
//        private double _workSum ;

//        private int Iterator
//        {
//            get { return _iterator; }
//            set { _iterator = value; }
//        }

//        private double WorkSum
//        {
//            get { return _workSum; }
//            set { _workSum = value; }
//        }

//        public double SquaresSum
//        {
//            get { return _squaresSum; }
//            set { _squaresSum = value; }
//        }

//        public int OutputNumbersAmount
//        {
//            get { return _outputNumbersAmount; }
//            set { _outputNumbersAmount = value; }
//        }

//        public double[] OutputNumbers
//        {
//            get { return _outputNumbers; }
//            set { _outputNumbers = value; }
//        }

//        public bool CanGetNaturalComponents
//        {
//            get { return _canGetNaturalComponents; }
//        }

//        //constructor
//        public CounterOfComponents(double squaresSum, int outputNumbersAmount)
//        {
//            SquaresSum = squaresSum;
//            OutputNumbersAmount = outputNumbersAmount;

//            Iterator = 0;
//            WorkSum = squaresSum;
//            OutputNumbers = new double[OutputNumbersAmount];

//        }

//        //counting

//        public bool CanGetNaturalComponents()
//        {
            
//            if (_iteratorInFinish) return true;

//            else return false;
//        }

//        public bool IsFinish()
//        {
//            if (WorkSum == 0 || Iterator < 0)
//            {
//                _iteratorInFinish = Iterator;
//                return true;
//            }
               
//            else
//                return false;
//        }


//        public bool CountNaturalComponents()
//        {
//            while(!IsFinish())
//            {
//                CountOutputNumber();
//            }
            
//        }

//        public void CountSetOfNumbers()
//        {
//            while (Iterator < OutputNumbersAmount)
//                CountOutputNumber();
//        }

//        public void CountOutputNumber(ref int i)
//        {
//            if (GetRoot(WorkSum) && CheckIfNumberIsCorrect(outputNumber))
//                OutputNumbers[Iterator] = OutputNumbers;
//            else
//            {
//                Renumerate();
//            }
            
//        }

//        public void Renumerate()
//        {
//            OutputNumbe
//        }

//    }
//}
