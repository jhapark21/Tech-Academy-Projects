using System;


namespace ExcerciseConsoleApp
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("please type in a number");
            string anynumber = Console.ReadLine();
            double number = Convert.ToDouble(anynumber);
            string result = (50 * number).ToString();
            Console.WriteLine(anynumber + " multiplies by 50 is " + result);
            Console.ReadLine();

            Console.WriteLine("please type in a number");
            string anynumber2 = Console.ReadLine();
            double number2 = Convert.ToDouble(anynumber2);
            string result2 = (number2 + 25).ToString();
            Console.WriteLine(anynumber2 + " plus 25 is " + result2);
            Console.ReadLine();

            Console.WriteLine("please type in a number");
            string anynumber3 = Console.ReadLine();
            double number3 = Convert.ToDouble(anynumber3);
            string result3 = (number3 / 12.5).ToString();
            Console.WriteLine(anynumber3 + " divided by 12.5 is " + result3);
            Console.ReadLine();

            Console.WriteLine("Please type in a number");
            string anyNumber4 = Console.ReadLine();
            double number4 = Convert.ToDouble(anyNumber4);
            bool greaterThan50 = 50 < number4;
            Console.WriteLine("Your number is greater than 50: " + greaterThan50);
            Console.ReadLine();

            Console.WriteLine("Please type in a number");
            string anyNumber5 = Console.ReadLine();
            double number5 = Convert.ToDouble(anyNumber5);
            string result5 = (number5 % 7).ToString();
            Console.WriteLine("The remainder of " + anyNumber5 + " divided by 7 is " + result5);
            Console.ReadLine();


        }
    }
}
