using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseClasses
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

            Console.WriteLine("Please choose an integer to do addition.");
            int inputNumber2 = Convert.ToInt32(Console.ReadLine());
            myMath.ThirdNumber = 20;
            myMath.FourthNumber = inputNumber2;
            Console.WriteLine("The result of the addition is: " + myMath.Addition().ToString());

            Console.WriteLine("Please choose an integer to do subtraction.");
            int inputNumber3 = Convert.ToInt32(Console.ReadLine());
            myMath.FifthNumber = 100;
            myMath.SixthNumber = inputNumber3;
            Console.WriteLine("The result of the subtraction is: " + myMath.Subtraction().ToString());

            Console.ReadLine();



            
            
        }
    }
}
