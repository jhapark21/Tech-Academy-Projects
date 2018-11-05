using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMethod_rev
{
    class Program
    {
        static void Main(string[] args)
        {

            Math myMath = new Math();

            Console.WriteLine("Please type in a first integer for muliplication.");
            myMath.firstInteger = Convert.ToInt32(Console.ReadLine());
            int result = myMath.Multiply(10);
            Console.WriteLine("Your number multiplied by 10 is: " + result);

            Console.WriteLine("Please type in a second integer.");
            myMath.secondInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you chose for second interger is: " + myMath.secondInteger);

            Console.ReadLine();
        }
    }
}
