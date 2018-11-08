using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstract
{
    class Employee : Person
    {
        
        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {

        }
        public override void SayName()
        {
            Console.WriteLine(base.FirstName + " " + base.LastName);
        }

    }
}
