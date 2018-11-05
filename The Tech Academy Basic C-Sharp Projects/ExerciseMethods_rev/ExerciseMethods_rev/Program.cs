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

            Console.WriteLine("Please type in an integer for muliplication.");
            myMath.Number = Convert.ToInt32(Console.ReadLine());
            int result = myMath.Multiply(12);
            Console.WriteLine("Your number multiplied by 12 is: " + result);

            Console.WriteLine("Please choose a decimal to do subtraction.");
            myMath.doubleNumber = Convert.ToDouble(Console.ReadLine());
            int result1 = Convert.ToInt32(myMath.Subtraction(10));
            Console.WriteLine("The result of the subtraction in integer is: " + result1);

            Console.WriteLine("Please choose a number to do addition.");
            string userNumber = Console.ReadLine();
            myMath.stringNumber = Convert.ToInt32(userNumber);
            int result2 = Convert.ToInt32(myMath.Addition(10));
            Console.WriteLine("The result of the addition in integer is: " + result2);


            Console.ReadLine();


        }
    }
}
