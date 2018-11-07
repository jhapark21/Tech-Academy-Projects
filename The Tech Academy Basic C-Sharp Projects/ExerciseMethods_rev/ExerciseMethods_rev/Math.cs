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

        }
        //Passes in an integer, resulting in integer. 
        public int doMath(int num)
        {
            return num * 10;
        }
        //Passes in a decimal, resulting in integer.
        public int doMath(decimal dec)
        {
            return Convert.ToInt32(dec - 5);
        }
        //Passes in a string, resulting in integer. 
        public int doMath(string str)
        {
            return Convert.ToInt32(str) + 60;
            
        }

    }
}
