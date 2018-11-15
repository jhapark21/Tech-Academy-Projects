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
            var dateFounded = new Founded(1981);
            Console.WriteLine("The {0} was established in {1}.", casinoName, dateFounded.Year);

            Console.ReadLine();
        }
    }
}
