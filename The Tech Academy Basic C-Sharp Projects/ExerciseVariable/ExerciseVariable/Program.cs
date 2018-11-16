using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            Console.WriteLine("Welcome to the {0}.", casinoName);

            var dateFounded = new Founded(1981);
            Console.WriteLine("The {0} was established in {1}.", dateFounded.Name, dateFounded.Year);

            Console.ReadLine();
        }
    }
}
