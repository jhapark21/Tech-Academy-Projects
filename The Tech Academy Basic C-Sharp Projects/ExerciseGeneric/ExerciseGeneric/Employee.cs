using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseGeneric
{
    class Employee<T> : Person
    {
        public List<T> Things = new List<T>();

        public int Id = 0;

        public Employee()
        {

        }
        public override void SayName()
        {
            Console.WriteLine(base.FirstName + " " + base.LastName);
        }
    }
}
