using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math myMath = new Math();
            myMath.FirstNumber = 10;
            myMath.SecondNumber = 20;
            Console.WriteLine("The first integer multiplied by 2 is: " + myMath.Twice().ToString());
            Console.WriteLine("The second interger is: " + myMath.SecondNumber);
            Console.ReadLine();
        }
    }
}
