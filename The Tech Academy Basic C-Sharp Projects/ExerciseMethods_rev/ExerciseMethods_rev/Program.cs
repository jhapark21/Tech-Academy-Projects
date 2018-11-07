using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMethods_rev
{
    class Program
    {
        static void Main(string[] args)
        {

            Math myMath = new Math();

            //Calls the first method, passing in integer 12 and multiplies by 10.
            Console.WriteLine(myMath.doMath(12));
            //Calls the second method, passing in decimal 19.3 and subtracts by 5. 
            Console.WriteLine(myMath.doMath(19.3m));
            //Calls the thrid method, passing in string "40" and adds by 60.
            Console.WriteLine(myMath.doMath("40"));

            Console.ReadLine();


        }
    }
}
