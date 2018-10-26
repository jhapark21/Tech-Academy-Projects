using System;


namespace ExcerciseConsoleApp
{
    class Program
    {
        static void Main()
        {

            console.writeline("please type in a number");
            string anynumber = console.readline();
            double number = convert.todouble(anynumber);
            string result = (50 * number).tostring();
            console.writeline(anynumber + " multiplies by 50 is " + result);
            console.readline();

            console.writeline("please type in a number");
            string anynumber2 = console.readline();
            double number2 = convert.todouble(anynumber2);
            string result2 = (number2 + 25).tostring();
            console.writeline(anynumber2 + " plus 25 is " + result2);
            console.readline();

            console.writeline("please type in a number");
            string anynumber3 = console.readline();
            double number3 = convert.todouble(anynumber3);
            string result3 = (number3 / 12.5).tostring();
            console.writeline(anynumber3 + " divided by 12.5 is " + result3);
            console.readline();

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
