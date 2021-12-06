using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {

            new Student("Mary", "Blue", 10),
            new Student("Becky", "Blue"),
            new Student("Simon", "Smith", 15),
            new Student("Fanny", "Fargo"),
            new Student("Pete", "Smith", 9),
            new Student("Bill", "Bailey"),
            new Student("John", "Long"),
            new Student("Van", "Hill", 36),
            new Student("Cindy", "Jones"),
            new Student("Marcy", "Michaels", 18),

            };

            Console.WriteLine(students[0].ShowStudent());
            students[0].AddCredits();
            Console.WriteLine(students[0].ShowStudent());
            students[0].AddCredits(1);
            Console.WriteLine(students[0].ShowStudent());
            students[0].ResetCredits();
            Console.WriteLine(students[0].ShowStudent());

            ShowAllStudent();

            foreach (Student s in students)
            {
                s.AddCredits();
            }


            ShowAllStudent();



            Console.WriteLine("");
            Console.WriteLine("press any key");

            Console.ReadKey();

            void ShowAllStudent()
            {
                Console.WriteLine("Name        Currrent   Total");
                Console.WriteLine("--------  ----------- ------");

                foreach (Student s in students)
                {
                    Console.WriteLine(s.ShowStudent());
                }
            }
        }
    }
}
