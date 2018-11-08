using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee("Sample", "Student");
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
