using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is to see if two Employee objects are equal
            Employee employee1 = new Employee("Sample", "Student");
            Employee employee2 = new Employee("Sample", "Student");

            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
