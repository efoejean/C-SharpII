using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAppII
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee[] employees =
                {

                new Employee("Tom Thompson", "(618) 562-9632", 1100),
                new Employee("Georgia Kenedy", "(618) 555-8632", 1320),
                new Employee("Pete Peterson", "(618) 666-9785", 1188),
                new Employee("Meredith Jones", "(618) 777-1536", 1795),
                new Employee("Jean Cummings", "(618) 888-9478", 1716),
                new Employee("Michael Robbins", "(618) 999-9426", 1200),
                new Employee("Polly Mark", "(618) 123-7556", -1520),

                };


            Console.WriteLine("All employees before raise");
            Console.WriteLine();
            ShowHeader();

            // variables

            int i;
            
            // Loop to display a number list
            for(i=0; i < employees.Count(); i++)
            {
                int id = i + 1;

                Console.WriteLine($"{id}.{employees[i].ShowEmployee()}");
            }

            Console.WriteLine();


            // give raise, by using the raise() method from Employee class
            foreach (Employee e in employees)
            {
                e.Raise();
            }

            Console.WriteLine("All employees after raise");
            Console.WriteLine();
            ShowHeader();

            // Loop to display a number list
            for (i = 0; i < employees.Count(); i++)
            {
                int id = i + 1;

                Console.WriteLine($"{id}.{employees[i].ShowEmployee()}");
            }

            Console.WriteLine();

            // accumulator 
            double totalMontly = 0.0;
            double totalAnnual = 0.0;

            // Use forEach to display the total monthly and annual.
            foreach(var e in employees)
            {
                totalMontly += e.MonthlySalary;
                totalAnnual += e.AnnualSalary;
            }
            // Display the total monthly and annual.
            Console.WriteLine($"Total monthly salary: {totalMontly:C}");
            Console.WriteLine($"Total monthly Annual: {totalAnnual:C}");

            Console.WriteLine();
            Console.WriteLine("Employee with Salaries over $1,500.00/month");
            Console.WriteLine();
            Console.WriteLine($"{"Name",-15}{"MonthlySalary",15:C}{"AnnualSalary",15:C}");
            Console.WriteLine($"{"-----------",-15}{"-------------",15:C}{"----------",15:C}");


            double maxSalary = 1500;
            Employee emp = null; //Flag variable

            //Loop to display Salarie over $1500
            for (i = 0; i < employees.Count(); i++)
            {
                if (employees[i].MonthlySalary > maxSalary)
                {
                    emp = employees[i];
                    Console.WriteLine(emp.ShowEmployee());
                }
            }

            if(emp != null)
            {
                
            }
            else
            {
                Console.WriteLine("Not found");
            }


            Console.WriteLine();
            Console.WriteLine("Result of sequential, case insensitive search for p");
            Console.WriteLine();
            ShowHeader();
            


            string search = "p";
            Employee strname = null; //Flag variable

            // Loop to Partial search in reverse order
            for (i = employees.Count()-1 ;i >=0; i --)
            {
                int id = i + 1;
                if (employees[i].Name.ToUpper().Contains(search.ToUpper()))
                {

                    strname = employees[i];
                    Console.WriteLine($"{id}.{strname.ShowEmployee()}");
                }
            }

            if (strname != null)
            {

            }
            else
            {
                Console.WriteLine("Not found");
            }



            Console.WriteLine();
            Console.WriteLine("Press any key");

            Console.ReadKey();

           //  Medoth to display header
            void ShowHeader()
            {
                Console.WriteLine($"{"#",-4}{"Name",-15}{"MonthlySalary",15:C}{"AnnualSalary",15:C}");
                Console.WriteLine($"{"--",-4}{"---------------",-15}{"-------------",15:C}{"------------",15:C}");

                Console.WriteLine();
            }
        }
    }
}
