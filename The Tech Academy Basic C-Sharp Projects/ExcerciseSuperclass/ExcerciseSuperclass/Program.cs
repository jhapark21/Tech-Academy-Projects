using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseSuperclass
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("Sample", "Student");
            employee.SayName();

            Console.ReadLine();

        }
    }
}
