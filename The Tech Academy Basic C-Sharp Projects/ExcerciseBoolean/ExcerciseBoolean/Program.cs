using System;


namespace ExcerciseBoolean
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int userAge = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool havedui = (dui == "false");

            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int userTicket = Convert.ToInt32(ticket);

            Console.WriteLine("Qualified?");
            bool userQualified = (userAge > 15 && havedui && userTicket < 3);
            Console.WriteLine(userQualified);

            Console.ReadLine();

        }
    }
}
