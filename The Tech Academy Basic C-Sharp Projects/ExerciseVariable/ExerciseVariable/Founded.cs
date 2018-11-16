using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseVariable
{
    class Founded
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Founded (string name, int year)
        {
            Name = name;
            Year = year;
        }
        public Founded (int year) : this("Grand Hotel and Casino", year)
        {
        }
    }
}
