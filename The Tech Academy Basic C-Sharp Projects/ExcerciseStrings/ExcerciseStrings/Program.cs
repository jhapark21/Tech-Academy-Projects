using System;


namespace ExcerciseStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "John";
            string userId = "JohnT11";
            string userPass = "JohnT123";

            string login = "Hello " + name + ". Your login ID is " + userId + " and your password is " + userPass;

            login = login.ToUpper();
            Console.WriteLine(login);

            System.Text.StringBuilder strname = new System.Text.StringBuilder();

            strname.Append("I am learning how to utilize strings in C#. \n First, I have concatenated three strings. \n Next, I have converted a string to uppercase. \n Lastly, I have created a stringbuilder and building a paragraph. \n I have learned how to utilized strings in C#.");
            Console.WriteLine(strname);

            Console.ReadLine();

        }
    }
}
