using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppPt3
{
    class Program
    {
        static void Main(string[] args)
        {
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

            int intCnt = 0; // Number of students
            int intSumCurrent = 0; // sum of all current credits

            Console.WriteLine($"{"Name",-15}{"Current",-10}{"Total",-5}");
            Console.WriteLine($"{"----",-15}{"-------",-10}{"-----",-5}");

            students[2].AddCredits(16);
            students[5].AddCredits(18);
            students[6].AddCredits(15);


            foreach (Student s in students)
            {
                if(s.CurrentCredits >= 12)
                {
                    
                    
                    Console.WriteLine(s.ShowStudent());
                    intCnt++;
                    intSumCurrent += s.CurrentCredits;
                }
                                            

            }

            Console.Write("Number of students: ");
            Console.WriteLine(intCnt.ToString());
            Console.Write("Sum of current credits: ");
            Console.WriteLine(intSumCurrent.ToString());
            Console.Write("Average FT current credits: ");
            Console.WriteLine((intSumCurrent / (double)intCnt).ToString());


            string strName = "Smith";

            Console.WriteLine("\nSearching for: " + strName);

            Student stu = null; // Flag variable
            int i;

            for(i = 0; i < students.Count(); i++)
            {
                //if (students[i].StudentLastName.ToUpper().IndexOf(strName.ToUpper(),0) >= 0)
                if (students[i].StudentLastName.ToUpper().Contains(strName.ToUpper()))
                {
                    stu = students[i];
                    break; // to get the first occurence
                   }
            }



            if (stu != null)
            {
                Console.WriteLine("Found: " + stu.FullName + " at index " + i ); // move this up to get all the occurence 

            }
            else
            {
                Console.WriteLine("Not found");
            }
            


            Console.ReadKey();

        }
    }
}
