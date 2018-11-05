using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMethods_rev
{
    class Math
    {

        //Default constructor
        public Math()
        {
            Number = 0;
        }

        //Property
        public int Number { get; set; }
        public double doubleNumber { get; set; }
        public int stringNumber { get; set; }

        //Method multiply
        public int Multiply(int num)
        {
            return num * Number;
        }

        //Method subtraction
        public double Subtraction(int num)
        {
            return doubleNumber - num;
        }

        //Method addition
        public int Addition(int num)
        {
            return stringNumber + num;
        }

    }
}
