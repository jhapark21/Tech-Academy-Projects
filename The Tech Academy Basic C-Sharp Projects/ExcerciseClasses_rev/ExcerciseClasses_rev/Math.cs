using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseClasses_rev
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

        //Method multiply
        public int Multiply(int num)
        {
            return num * Number;
        }

        //Method addition
        public int Addition(int num)
        {
            return num + Number;
        }

        //Method subtraction
        public int Subtraction(int num)
        {
            return Number - num;
        }


    }
}
