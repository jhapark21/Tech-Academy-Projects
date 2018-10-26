using System;


namespace ExcerciseIncome
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anynoymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourRate1 = Console.ReadLine();
            int hRate1 = Convert.ToInt32(hourRate1);
            Console.WriteLine("Hours worked per week?");
            string hourWeek1 = Console.ReadLine();
            int hWeek1 = Convert.ToInt32(hourWeek1);
            
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourRate2 = Console.ReadLine();
            int hRate2 = Convert.ToInt32(hourRate2);
            Console.WriteLine("Hours worked per week?");
            string hourWeek2 = Console.ReadLine();
            int hWeek2 = Convert.ToInt32(hourWeek2);

            Console.WriteLine("Weekly salary of Person 1:");
            string wkSalary1 = (hRate1 * hWeek1).ToString();
            Console.WriteLine(wkSalary1);
            Console.WriteLine("Weekly salary of Person 2:");
            string wkSalary2 = (hRate2 * hWeek2).ToString();
            Console.WriteLine(wkSalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int p1Salary = Convert.ToInt32(wkSalary1);
            int p2Salary = Convert.ToInt32(wkSalary2);
            bool moreSalary = p1Salary > p2Salary;
            Console.WriteLine(moreSalary);
            Console.ReadLine();



        }
    }
}
