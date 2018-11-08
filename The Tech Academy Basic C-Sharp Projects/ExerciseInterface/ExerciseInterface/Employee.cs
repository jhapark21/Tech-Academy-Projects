using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseInterface
{
    class Employee : Person, IQuittable
    {

        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {

        }

        public override void SayName()
        {
            Console.WriteLine(base.FirstName + " " + base.LastName);
        }

        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
