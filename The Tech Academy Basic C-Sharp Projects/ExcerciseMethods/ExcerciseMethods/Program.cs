using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math myMath = new Math();

            Console.WriteLine("Please choose an integer to do multiplication.");
            int inputNumber1 = Convert.ToInt32(Console.ReadLine());
            myMath.FirstNumber = 10;
            myMath.SecondNumber = inputNumber1;
            Console.WriteLine("The result of the multiplication is: " + myMath.Multiple().ToString());

            Console.WriteLine("Please choose a decimal to do addition.");
            double userDecimal = Convert.ToDouble(Console.ReadLine());
            int inputNumber2 = Convert.ToInt32(userDecimal);
            myMath.ThirdNumber = 20;
            myMath.FourthNumber = inputNumber2;
            Console.WriteLine("The result of the addition in integer is: " + myMath.Addition().ToString());

            Console.WriteLine("Please choose an integer to do subtraction.");
            string userNumber = Console.ReadLine();
            int inputNumber3 = Convert.ToInt32(userNumber);
            myMath.FifthNumber = 100;
            myMath.SixthNumber = inputNumber3;
            Console.WriteLine("The result of the subtraction is: " + myMath.Subtraction().ToString());

            Console.ReadLine();
        }
    }
}
