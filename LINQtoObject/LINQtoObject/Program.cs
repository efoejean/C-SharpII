using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 6 };

            Console.WriteLine("Filter by > 4");
            var filtered = from v in values                         
                           where v > 4
                           select v;

            showNumber(filtered);

            Console.WriteLine("Sorted by v");
            var filterSort = from v in values
                             orderby v
                             select v;
            showNumber(filterSort);

            Console.WriteLine("Over 4 double");
            var doubled = from v in filtered
                         select v * 2;

            
            showNumber(doubled);





            Student[] students = new Student[] {
                new Student("Mary", "Blue"),
                new Student("Becky", "Blue"),
                new Student("Simon", "Smith", 15),
                new Student("Fanny", "Fargo"),
                new Student("Pete", "Smith", 9),
                new Student("Bill", "Bailey"),
                new Student("John", "Long"),
                new Student("Van", "Hill", 36),
                new Student("Cindy", "Jones"),
                new Student("Marcy", "Michaels", 18)
            };

            
            showStudents("All students", students);

            var stus = from s in students
                       where s.TotalCredits > 10
                       select s;
            showStudents("Student with total over 10", stus);

            var stus2 = from s in students
                        orderby s.StudentLastName, s.StudentFirstName
                        select s;

            showStudents("Students orderes by Last Name", stus2);

            Console.WriteLine();
            Console.WriteLine("Student names and classes");

            var studentNames = from s in students
                               let divCredit = s.TotalCredits/3
                               select new { full = s.FullName, Classes = divCredit };

            foreach(var v in studentNames)
            {
                Console.WriteLine(v.full + "\t" + v.Classes);
            }

            Console.WriteLine();
           
            int countStudent = students.Count();

            Console.WriteLine($"Number of students {countStudent}");

            Console.WriteLine();

            int countStudent2 =(from s in studentNames where s.Classes > 0  select s).Count();

            Console.WriteLine($"Number of students with classes {countStudent2}");

            Console.WriteLine();

            int countStudent3 = (from s in students select s.StudentLastName).Distinct().Count();

            Console.WriteLine($"Number of students with the same last name {countStudent3}");

            Console.WriteLine();

            string disctintLastName = (from s in students select s.StudentLastName).Distinct().First();

            Console.WriteLine($"First distinct studentlast name is {disctintLastName}");

            Console.ReadKey();


            void showNumber(IEnumerable<int> set)
            {
                foreach(int v in set)
                {
                    Console.WriteLine(v.ToString());
                }
            }

            void showStrings(IEnumerable<string> set)
            {
                foreach (string v in set)
                {
                    Console.WriteLine(v);
                }
            }

            void showStudents(string title, IEnumerable<Student> set)
            {
                Console.WriteLine();
                Console.WriteLine(title);
                Console.WriteLine($"{"Student",-18}{"Current",-8}{"Total",-8}");
                Console.WriteLine($"{"--------",-18}{"------",-8}{"------",-8}");
                foreach (Student s in set)
                {
                    Console.WriteLine(s.ShowStudent());
                }
            }
                
            
            
        }
    }
}
