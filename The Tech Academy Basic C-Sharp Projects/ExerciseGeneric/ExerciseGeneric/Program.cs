using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> eString = new Employee<string>();
            eString.Things.Add("blue");
            eString.Things.Add("red");
            eString.Things.Add("green");
            for (int i = 0; i < eString.Things.Count; i++)   
                Console.WriteLine(eString.Things[i]);

            Employee<int> iString = new Employee<int>();
            iString.Things.Add(1);
            iString.Things.Add(2);
            iString.Things.Add(3);
            for (int j = 0; j < iString.Things.Count; j++)
                Console.WriteLine(iString.Things[j]);

            Console.ReadLine();
        }
    }
}
