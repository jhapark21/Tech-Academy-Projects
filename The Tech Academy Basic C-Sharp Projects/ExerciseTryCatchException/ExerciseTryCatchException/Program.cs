using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTryCatchException
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            try
            {
                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    Console.Write("How old are you?: ");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter integers only.");
                }
                if (age <= 0)
                {
                    throw new AgeException();
                }
                Console.WriteLine("You are born in " + DateTime.Now.AddYears(-age).Year);
            }
            catch (AgeException)
            {
                Console.WriteLine("Your age cannot be zero or negative.");
                goto Start;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please contact your System Administrator.");
                goto Start;
            }


            Console.ReadLine();

        }
    }
}
