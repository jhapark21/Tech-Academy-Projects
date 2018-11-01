using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> numbers = new List<int>() { 10, 12, 15, 18, 23 };
            Console.WriteLine("Pick a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you chose will be divided by the numbers: 10, 12, 15, 18, 23.");
            foreach (int number in numbers)
            {
                Console.WriteLine(number / userNumber); //This will show the result of the user's input diveded by the list of numbers. 
            }
            
        }
        //This will give a user an error message when the user types in 0 for the number.
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
            return;
        }
        //This will give a user an error message when the user types in non whole number. 
        catch (FormatException ex)
        {
            Console.WriteLine("Please only type in a whole number.");
            return;
        }
        //This will let the program execute even after catching error.
        finally
        {
            Console.ReadLine();
        }
    }
}

