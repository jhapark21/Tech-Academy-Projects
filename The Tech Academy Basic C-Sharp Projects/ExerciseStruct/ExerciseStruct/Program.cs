using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 1.5m;

            Console.WriteLine("The decimal number is: " + number.Amount);
            Console.ReadLine();
        }
    }
}
