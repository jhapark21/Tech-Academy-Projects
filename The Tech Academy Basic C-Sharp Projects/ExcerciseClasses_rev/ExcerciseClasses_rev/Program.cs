using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseClasses_rev
{
    class Program
    {
        static void Main(string[] args)
        {

            Math myMath = new Math();

            Console.WriteLine("Please type in an integer for muliplication.");
            myMath.Number = Convert.ToInt32(Console.ReadLine());
            int result = myMath.Multiply(10);
            Console.WriteLine("Your number multiplied by 10 is: " + result);

            Console.WriteLine("Please type in an integer for addition.");
            myMath.Number = Convert.ToInt32(Console.ReadLine());
            int result1 = myMath.Addition(10);
            Console.WriteLine("Your number added by 10 is: " + result1);

            Console.WriteLine("Please type in an integer for subtraction.");
            myMath.Number = Convert.ToInt32(Console.ReadLine());
            int result2 = myMath.Subtraction(10);
            Console.WriteLine("Your number subtracted by 10 is: " + result2);



            Console.ReadLine();





        }
    }
}
