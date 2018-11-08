using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseSuperclass
{
    class Employee : Person
    {
        int Id = 0;

        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {

        }


    }
}
