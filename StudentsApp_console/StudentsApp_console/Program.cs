using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp_console
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student[] students = new Student[] {
            //    new Student("Mary", "Blue"),
            //    new Student("Becky", "Blue"),
            //    new Student("Simon", "Smith", 15),
            //    new Student("Fanny", "Fargo"),
            //    new Student("Pete", "Smith", 9),
            //    new Student("Bill", "Bailey"),
            //    new Student("John", "Long"),
            //    new Student("Van", "Hill", 36),
            //    new Student("Cindy", "Jones"),
            //    new Student("Marcy", "Michaels", 18)
            //};

            List<Student> students = new List<Student>() {
              new Student("Marry", "Blue"),
              new Student("Simon", "Smith", 15),
              new Student("Fanny", "Fargo"),
              new Student("Pete", "Smith", 9),
              new Student("Bill", "Bailey"),
              new Student("John", "Long"),
              new Student("Van", "Hill", 36),
              new Student("Cindy", "Jones"),
              new Student("Sean", "Childs"),
              new Student("Marcy", "Michaels", 18)

            };


            students[2].AddCredits(16);
            students[5].AddCredits(18);
            students[6].AddCredits(15);

            //Show all students
            //Console.Write("\nAll students:\n");
            //foreach (var s in students)
            //{
            //    Console.WriteLine(s.ShowStudent());
            //}

            ShowStudents("All Students", students);
            //Aggregates
            int cntFT = 0;   //number of FT students
            int sumFT = 0;  //sum of all FT current credits

            //Console.Write("\nFull-time students:\n");
            //foreach (var s in students)
            //{
            //    if (s.CurrentCredits >= 12)
            //    {
            //        cntFT++;
            //        sumFT += s.CurrentCredits;
            //        Console.WriteLine(s.ShowStudent());
            //    }
            //}

            var fulltime = from s in students
                           where s.CurrentCredits >= 12
                           select s;

            ShowStudents("Full time Students", fulltime);

            cntFT = fulltime.Count();
            sumFT = (from s in fulltime select s.CurrentCredits).Sum();

            


            Console.Write("\nNumber of FT students: ");
            Console.WriteLine(cntFT.ToString());
            Console.Write("\nSum of FT current credits: ");
            Console.WriteLine(sumFT.ToString());
            Console.Write("\nAverage FT current credits: ");
            if (fulltime.Any())  // cntFT > 0
            {
                double avgFT = (from s in fulltime select s.CurrentCredits).Average();

                Console.WriteLine(avgFT.ToString());
            }
            else
            {
                Console.WriteLine("Divide by zero error");
            }

            //Sequential Search
            Student stu = null; //flag 
            string strName = "j";
            int i;

            //Console.WriteLine("\nSearching for: " + strName);

            //for (i = 0; i < students.Count(); i++)
            //{
            //    //if (students[i].StudentLastName.ToLower().IndexOf(strName.ToLower(),0) >= 0)
            //    if (students[i].StudentLastName.ToLower().Contains(strName.ToLower()))
            //    {
            //        stu = students[i];
            //        break;
            //    }

            //}

            var matches = from s in students
                          where s.FullName.ToLower().Contains(strName.ToLower())
                          select s;

            stu = matches.FirstOrDefault();
            i = students.IndexOf(stu);


            if (matches.Any()) //stu != null
            {
                Console.WriteLine("Found " + stu.FullName + " at index " + i);
            }
            else
            {
                Console.WriteLine("Not found");
            }


            students.Insert(0, new Student("mary", "arfus"));
            ShowStudents("Student after inserting at begining", students);
            students.Add(new Student() { StudentFirstName = "Tim", CurrentCredits = 10 });
            ShowStudents("Student after adding one with 10 credits", students);
            students.Remove(stu);
            ShowStudents($"Student after revoming {stu.FullName}", students);
            students.RemoveAt(5);
            ShowStudents("Student after removing at 6th student", students);




            foreach(Student s in students)
            {


                s.AddCredits(18);
            }
            ShowStudents("stidents after adding 18 credits", students);

            Student.maxCredits = 21;

            foreach (Student s in students)
            {


                s.AddCredits(3);
            }
            ShowStudents("stidents after raising max adding  3 credits", students);




            Console.ReadKey();

            void ShowStudents(string title, IEnumerable<Student> set)
            {
                Console.WriteLine();
                Console.WriteLine(title);
                Console.WriteLine($"{"Student",-18}{"Current",-8}{"Total",-8}");
                Console.WriteLine($"{"-------",-18}{"-------",-8}{"-----",-8}");

                var stus = set.ToArray();
                for (int ii = 0; ii < stus.Count(); ii++)
                {
                    Console.WriteLine($"{ ii + 1 + ".",-3}{stus[ii].ShowStudent()}");

                }
                
            }

        }
    }
}
