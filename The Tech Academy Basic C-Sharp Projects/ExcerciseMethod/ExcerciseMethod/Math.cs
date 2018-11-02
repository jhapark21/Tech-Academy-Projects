using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseMethod
{
    class Math
    {
        private int _firstNumber;
        private int _secondNumber;

        public Math(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }
        public Math()
        {
            _firstNumber = 0;
            _secondNumber = 0;
        }
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
        public int Twice()
        {
            return _firstNumber * 2;
        }
    }
}