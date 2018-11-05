using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMethod_rev
{
    class Math
    {
        public int firstInteger { get; set; }
        public int secondInteger { get; set; }

        public Math()
        {
            firstInteger = 0;
            secondInteger = 0;
        }

        public int Multiply (int num)
        {
            return num * firstInteger;
        }


    }
}
