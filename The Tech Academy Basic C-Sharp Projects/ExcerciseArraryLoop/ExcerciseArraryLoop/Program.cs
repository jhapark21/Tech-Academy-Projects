using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
        static void Main(string[] args)
        {

        //this will ask the user to input some text and will print each string on a separate line.
        Console.WriteLine("please ask me what colors of paint i have.");
        string[] colors = { "red", "blue", "cyan", "black", "silver" };
        string userinput = Console.ReadLine();
        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine(colors[i]);

        }
        Console.ReadLine();

        //This will create an infinite loop with while.
        string input = string.Empty;
        int intValue = 0;
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {

            while (numbers[i] != 15)
            {
                Console.WriteLine(intValue);
            }
        }
        Console.ReadLine();

        //This fixed infinite loop with if. 
        string input2 = string.Empty;
        int intValue2 = 0;
        int[] numbers2 = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {

            if (numbers[i] != 5)
            {
                Console.WriteLine(intValue2);
            }
        }
        Console.ReadLine();

        //this loop is using < operator whether to continue iterating.
        int[] satscores = { 1358, 1812, 2382, 2132, 1480, 1290, 1670, 1500 };
        for (int i = 0; i < satscores.Length; i++)
        {
            if (satscores[i] < 1500)
            {
                Console.WriteLine("Fail Score for SAT: " + satscores[i]);
            }
        }
        Console.ReadLine();

        //This loop is using <= operator whether to continue iterating.
        int[] satScores = { 1358, 1812, 2382, 2132, 1480, 1290, 1670, 1500 };
        for (int i = 0; i < satScores.Length; i++)
        {
            if (satScores[i] <= 1500)
            {
                Console.WriteLine("Fail Score for SAT: " + satScores[i]);
            }
        }
        Console.ReadLine();


        //This is list of strings where user can input index number to choose a name only from the list.
        Console.WriteLine("Please type in a name from the list for a number: John, Jessica, Rachel, Scott, and Judith");
        List<string> names = new List<string>() { "John", "Jessica", "Rachel", "Scott", "Judith" };
        string inputName = Console.ReadLine();
        foreach (string name in names)
        {
            if (name == inputName)
            {
                int index = names.IndexOf(inputName);
                Console.WriteLine(index);
                break;
            }
            else
            {
                Console.WriteLine("Please choose a name from the list.");
                break;
            }

        }
        Console.ReadLine();


        // This has two identical strings in the list and will let the user know if the identical strings are typed.
        Console.WriteLine("Please type in a color from the list for a number: red, blue, green, purple and yellow");
        List<string> colorChoice = new List<string>() { "red", "blue", "green", "purple", "yellow", "red" };
        string inputColor = Console.ReadLine();
        foreach (string color in colorChoice)
        {
            if (color == inputColor)
            {
                int index = colorChoice.IndexOf(inputColor);
                Console.WriteLine(index);
                break;
            }
            else if (inputColor == "red")
                {
                Console.WriteLine("List contains duplicate colors of red.");
            }
            else
            {
                Console.WriteLine("Please choose a color from the list.");
                break;
            }

        }


        Console.ReadLine();











    }

}


