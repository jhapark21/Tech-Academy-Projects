using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOverload
{
    class Employee : Person
    {
        public int Id = 0;

        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {

        }
        //This will check if Employee one and two are the same coparing their Ids.
        public static bool operator == (Employee one, Employee two)
        {
            return one.Id == two.Id;
        }
        //This will check if Employee one and two are different coparing their Ids.
        public static bool operator != (Employee one, Employee two)
        {
            return one.Id != two.Id;
        }

        public override void SayName()
        {
            Console.WriteLine(base.FirstName + " " + base.LastName);
        }
    }
}
