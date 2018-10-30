using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
            //This is an array of strings that lets the user choose any index number less than 5 and displays what kind of fruit the user picked.
            Console.WriteLine("Please choose any index for fruit name.");
            string[] stringArray = { "Apple", "Grape", "Pear", "Strawberry", "Orange" };
            string numFruit = Console.ReadLine();
            int numberFruit = Convert.ToInt32(numFruit);
            if (numberFruit > 4)
            {
                Console.WriteLine("Please type in index less than 5.");
                Console.ReadLine();
            }
            Console.WriteLine(stringArray[numberFruit]);
            Console.ReadLine();

            //This is an array of integers that lets the user choose any index number less than 5 and displays what number the user picked. 
            Console.WriteLine("Please choose any index for random numbers.");
            int[] intArray = { 56, 1, 18, 91, 73 };
            int numberRandom = Convert.ToInt32(Console.ReadLine());
            if (numberRandom > 4)
            {
                Console.WriteLine("Please type in index less than 5.");
                Console.ReadLine();
            }
            Console.WriteLine(intArray[numberRandom]);
            Console.ReadLine();

            //This is a list of strings that lets the user choose any index number and displays what name of person the user picked. 
            Console.WriteLine("Please choose any index for person name.");
            List<string> intList = new List<string>();
            intList.Add("John");
            intList.Add("David");
            intList.Add("Jude");
            intList.Add("Christine");
            intList.Add("Sophie");
            string namePerson = Console.ReadLine();
            int nPerson = Convert.ToInt32(namePerson);
            Console.WriteLine(intList[nPerson]); 
            Console.ReadLine();

    }
}

