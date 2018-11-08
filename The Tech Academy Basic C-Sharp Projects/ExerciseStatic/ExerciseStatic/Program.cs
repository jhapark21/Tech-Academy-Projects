using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Math myMath = new Math();

            Console.WriteLine("Please type in an integer to be divided by 2.");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int outputNumber;
            myMath.outInteger(out outputNumber, inputNumber);
            Console.WriteLine("The output number is: " + outputNumber);

            Console.WriteLine("Please type in an integer to be multiplied by 10 and divided by 3.");
            int inputNumber2 = Convert.ToInt32(Console.ReadLine());
            int outputNumber2;
            myMath.outParameter(inputNumber2, out outputNumber2);
            Console.WriteLine("The output number is: " + outputNumber2);

            Console.WriteLine("Please type in a decimal to be multiplied by 10 and divided by 2.");
            decimal inputNumber3 = Convert.ToDecimal(Console.ReadLine());
            int outputNumber3;
            myMath.outParameter(inputNumber3, out outputNumber3);
            Console.WriteLine("The output number is: " + outputNumber3);

            Console.ReadLine();
        }
    }
}
