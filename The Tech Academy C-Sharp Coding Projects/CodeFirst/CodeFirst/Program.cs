using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student() { Name = "Ji Hyeuk Park" };

                var histSubject = new Subject() { Name = "History" };
                var langSubject = new Subject() { Name = "Language" };

                student.Subjects.Add(histSubject);
                student.Subjects.Add(langSubject);

                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}
