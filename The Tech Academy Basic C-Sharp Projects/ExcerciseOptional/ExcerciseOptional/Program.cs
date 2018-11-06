using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseOptional
{
    class Program
    {
        static void Main(string[] args)
        {
            Math myMath = new Math();

            Console.WriteLine("Please type in a first integer for muliplication.");
            myMath.firstInteger = Convert.ToInt32(Console.ReadLine());
            int result1 = myMath.Multiply(10);
            Console.WriteLine("Your number multiplied by 10 is: " + result1);

            Console.WriteLine("Optional: you do not need to enter anything for this.\n Please type in a second integer for addition.");
            myMath.secondInteger = Convert.ToInt32(Console.ReadLine());
            int result2 = myMath.Addition(10);
            Console.WriteLine("The number added by 10 is: " + result2);
            

            Console.ReadLine();
        }
    }
    
}
