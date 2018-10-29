using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a color?");
            string color = Console.ReadLine();
            bool guessColor = false;

            do
            {
                switch (color)
                {
                    case "red":
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. That is correct.");
                        guessColor = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;


                }
            }
            while (!guessColor);
            Console.ReadLine();
        }
    }
}
