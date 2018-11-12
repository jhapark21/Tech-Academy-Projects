using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please type in current day of the week.");
            string userInput = Console.ReadLine();

            DaysOfWeek today;


            try
            {
                today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput);
                Console.WriteLine("Current day of the week is: " + today);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                return;
            }
            finally
            {
                Console.ReadLine();
            }
        }
        
    }
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
