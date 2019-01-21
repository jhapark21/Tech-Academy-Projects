using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Given an Array of integers, write a method to total the odd numbers. 
            int[] array = { 1, 3, 5, 8, 11 };
            int odd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    odd += array[i];
                }
            }
            Console.WriteLine("Total odd numbers is: " + odd);
            Console.ReadLine();

            ///Given an array of integers, write a method to sum the elements in
            ///the array, knowing that some of the elements may be very large integers. 
            int[] array1 = { 1, 13, 200, 51230, 582348593 };
            int sum = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
            }
            Console.WriteLine("The sum of the elements in the array is: " + sum);
            Console.ReadLine();

            ///Given a string, reverse it
            string inputString = "hello world";
            Console.WriteLine(inputString);
            string reversedString = string.Join(" ", inputString
                .Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine(reversedString);
            Console.ReadLine();

            ///Given a string, remove any repeated letters.
            string inputString1 = "hello world";
            Console.WriteLine(inputString1);
            string deletedString = "";
            var set = new HashSet<char>();
            foreach (var c in inputString1)
            {
                if (set.Add(c))
                    deletedString += c;
            }
            Console.WriteLine(deletedString);
            Console.ReadLine();


            ///FizzBuzz
            for (int i = 1; i < 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            /// another solution
            for (int i = 1; i < 100; i++)
            {
                var divByThree = i % 3 == 0;
                var divByFive = i % 5 == 0;

                if ((divByThree) && (divByFive))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (divByThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if (divByFive)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
 