using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.Write("Please type in a number: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime currentTime = DateTime.Now;
            DateTime laterTime = currentTime.AddHours(hours);
            Console.WriteLine("The time after {0} hours is {1}.", hours, laterTime);

            Console.ReadLine();
        }
    }
}
