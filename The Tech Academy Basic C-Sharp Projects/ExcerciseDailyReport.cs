using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string nameCourse = Console.ReadLine();
            Console.WriteLine("You are in course: " + nameCourse);
           
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("You are on page: " + pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");

            bool value = true;
            Console.ReadLine();
            if (value)
            {
                Console.WriteLine("Please contact instructors.");
            }
            if (!value)
            {
                Console.WriteLine("Keep up the good work!");
            }
           
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("You are doing great!");

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("Your feedback is deeply appreciated.");
        

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            Console.WriteLine("You studied " + studyHours + " hours today!");
            Console.ReadLine();

        

        }
    }
}
