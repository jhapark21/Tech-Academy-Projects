using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list of 10 employees, 2 employees with the same first name of Joe
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Joe", "Jenkins", 1));
            employees.Add(new Employee("Catarina", "King", 2));
            employees.Add(new Employee("Kramer", "Johnson", 3));
            employees.Add(new Employee("Scott", "Jo", 4));
            employees.Add(new Employee("Chloe", "Na", 5));
            employees.Add(new Employee("Chris", "Patterson", 6));
            employees.Add(new Employee("Joanne", "Sana", 7));
            employees.Add(new Employee("Joe", "Davidson", 8));
            employees.Add(new Employee("Audrie", "Asaro", 9));
            employees.Add(new Employee("David", "Patrason", 10));

            //Creating a list of employees with the first name of Joe using the foreach loop.
            List<Employee> employeeJoes = new List<Employee>();
            foreach (Employee joe in employees)
            {
                if (joe.FirstName == "Joe")
                {
                    employeeJoes.Add(joe);
                }   
            }
            foreach (Employee joe in employeeJoes)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            //Creating a list of employees with the first name of Joe using the Lambda expression.
            List<Employee> empJoes = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in empJoes)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            //Creating a list of employees with id numbers greater 5. 
            List<Employee> higherId = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in higherId)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            Console.ReadLine();   

        }
    }
}
