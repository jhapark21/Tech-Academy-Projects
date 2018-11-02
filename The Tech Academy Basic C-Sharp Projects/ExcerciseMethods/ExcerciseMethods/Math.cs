using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseMethods
{
    class Math
    {
        //Priavate variables
        private int _firstNumber;
        private int _secondNumber;
        private double _thirdNumber;
        private double _fourthNumber;
        private int _fifthNumber;
        private int _sixthNumber;

        //Creating a constructor
        public Math(int firstNumber, int secondNumber, double thirdNumber, double fourthNumber, int fifthNumber, int sixthNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
            _thirdNumber = thirdNumber;
            _fourthNumber = fourthNumber;
            _fifthNumber = fifthNumber;
            _sixthNumber = sixthNumber;
        }


        //Creating default constructor
        public Math()
        {
            _firstNumber = 0;
            _secondNumber = 0;
            _thirdNumber = 0;
            _fourthNumber = 0;
            _fifthNumber = 0;
            _sixthNumber = 0;
        }

        //Property to Set and Get _firstNumber
        public int FirstNumber
        {
            set
            {
                _firstNumber = value;
            }
            get
            {
                return _firstNumber;
            }
        }
        //Property to Set and Get _secondNumber
        public int SecondNumber
        {
            set
            {
                _secondNumber = value;
            }
            get
            {
                return _secondNumber;
            }
        }
        //Property to Set and Get _thirdNumber
        public double ThirdNumber
        {
            set
            {
                _thirdNumber = value;
            }
            get
            {
                return _thirdNumber;
            }
        }
        //Property to Set and Get _fourthNumber
        public double FourthNumber
        {
            set
            {
                _fourthNumber = value;
            }
            get
            {
                return _fourthNumber;
            }
        }
        //Property to Set and Get _fifthNumber
        public int FifthNumber
        {
            set
            {
                _fifthNumber = value;
            }
            get
            {
                return _fifthNumber;
            }
        }
        //Property to Set and Get _sixthNumber
        public int SixthNumber
        {
            set
            {
                _sixthNumber = value;
            }
            get
            {
                return _sixthNumber;
            }
        }
        //Property to get multiplication of _firstNumber and _secondNumber
        public int Multiple()
        {
            return _firstNumber * _secondNumber;
        }
        //Property to get addition of _thirdNumber and _fourthNumber, allowing decimal input and output is integer
        public double Addition()
        {
            return _thirdNumber + _fourthNumber;
        }
        //Property to get subtraction of _fifthNumber and _sixthNumber, allowing string input and output is integer
        public int Subtraction()
        {
            return _fifthNumber - _sixthNumber;
        }
    }
}
