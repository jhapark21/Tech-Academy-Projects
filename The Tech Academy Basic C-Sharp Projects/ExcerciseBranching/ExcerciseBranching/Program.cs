using System;


namespace ExcerciseBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please type in the weight of the package.");
            int pckWeight = Convert.ToInt32(Console.ReadLine());
                if (pckWeight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                    return;
                }

            Console.WriteLine("Please type in the width of the package.");
            int pckWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type in the height of the package.");
            int pckHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type in the length of the package.");
            int pckLength = Convert.ToInt32(Console.ReadLine());
                if (pckWidth + pckHeight + pckLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Exress.");
                    Console.ReadLine();
                    return;
                }

            decimal pckPrice = (pckWidth + pckHeight + pckLength) * pckWeight / 100m;
            Console.WriteLine("Your estimated total for shipping this package is: $" + pckPrice);
            Console.WriteLine("Thank you for using Package Express.");
            Console.ReadLine();
 

        }
    }
}
