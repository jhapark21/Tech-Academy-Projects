using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExerciseIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number: ");
            string text = Console.ReadLine();
            File.WriteAllText(@"D:\Visual Studio\Projects\log.txt", text); 
            using (StreamWriter file = new StreamWriter(@"D:\Visual Studio\Projects\log.txt", true))
            {
                file.WriteLine(text);
                Console.WriteLine("The number you chose is: " + text);
            }
            
            Console.ReadLine();
        }
    }
}
