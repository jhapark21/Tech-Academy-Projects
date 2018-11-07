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

            Console.WriteLine("Please type in two integers, but the second integer can be left blank.");
            string firstInteger = Console.ReadLine();
            string secondInteger = Console.ReadLine();

            int result;
            if (String.IsNullOrWhiteSpace(secondInteger))
            {
                result = myMath.Addition(Convert.ToInt32(firstInteger));
            }
            else
            {
                result = myMath.Addition(Convert.ToInt32(firstInteger), Convert.ToInt32(secondInteger));
            }

            Console.WriteLine("The addition of you number(s) is: " + result);

            Console.ReadLine();
        }
    }
    
}

