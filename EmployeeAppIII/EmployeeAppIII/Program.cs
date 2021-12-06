using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAppIII
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Employee> employees = new List<Employee>()
            {

                new Employee("Tom Thompson", "(618) 562-9632", 1100),
                new Employee("Georgia Kenedy", "(618) 555-8632", 1320),
                new Employee("Pete Peterson", "(618) 666-9785", 1188),
                new Employee("Meredith Jones", "(618) 777-1536", 1795),
                new Employee("Jean Cummings", "(618) 888-9478", 1716),
                new Employee("Michael Robbins", "(618) 999-9426", 1200),
                new Employee("Polly Mark", "(618) 123-7556", -1520),

            };

            
            Console.WriteLine();
            ShowEmployee("All employees before raise", employees);
            Console.WriteLine();

            Console.WriteLine();


            //give raise, by using the raise() method from Employee class
            foreach (Employee e in employees)
            {
                e.Raise();
            }

             Console.WriteLine();
             ShowEmployee("All employees after raise", employees);
             Console.WriteLine();



            //LINQ queries using the Sum extension method

            double totalMontly = (from e in employees
                                  select e.MonthlySalary).Sum();
            double totalAnnual = (from e in employees select e.AnnualSalary).Sum();

            // Display the total monthly and annual.
            Console.WriteLine($"Total monthly salary: {totalMontly:C}");
            Console.WriteLine($"Total monthly Annual: {totalAnnual:C}");
            

            Console.WriteLine();

            double maxSalary = 1500;
            Employee emp = null; //Flag variable

            Console.WriteLine();
            Console.WriteLine("Employee with Salaries over $1,500.00/month");
            Console.WriteLine();
            Console.WriteLine($"{"Name",-15}{"MonthlySalary",15:C}{"AnnualSalary",15:C}");
            Console.WriteLine($"{"-----------",-15}{"-------------",15:C}{"----------",15:C}");

            //Loop to display Salarie over $1500
            for (int i = 0; i < employees.Count(); i++)
            {
                if (employees[i].MonthlySalary > maxSalary)
                {
                    emp = employees[i];
                    Console.WriteLine(emp.ShowEmployee());
                }
            }

            if (emp != null)
            {

            }
            else
            {
                Console.WriteLine("Not found");
            }


            //Sequential Search
            //uses a LINQ expression to return employees with names that begin with a specific search string

            string search = "m";

              var  employeeSearch = from e in employees
                                 where e.Name.ToLower().StartsWith(search.ToLower())
                                 select e;
            

            if (employeeSearch.Any())
            {
                ShowEmployee("Results of Search for employee name begining with 'm' ", employeeSearch);
            }
            else
            {
                Console.WriteLine("Not found");
            }


            //Use the result of the search above together with the RemoveAt method to remove the first
            //occurrence of an employee with a specified name
          
            Employee first = employeeSearch.First();
            int firstIndex = employees.IndexOf(first);

            employees.RemoveAt(firstIndex);

            Console.WriteLine();
            ShowEmployee($"Employees after removin first occurence of employee name beginning with 'm' at index {firstIndex}", employees);



            //Add yourself as an employee to the first position of the collection. Use an object initializer with
            //name only.
            employees.Insert(0, new Employee() {Name= "Efoe Gnassia" });

            ShowEmployee("mployees before increasing raise  from 10%", employees);
            Console.WriteLine();



            // Call the static method 

            Employee.IncreaseRaise();

            foreach(Employee e in employees)
            {
                e.Raise();

            }

            Console.WriteLine();
            ShowEmployee("Employees after increasing raise to 11%", employees);
            Console.WriteLine();


            Console.WriteLine("Press any key");

            Console.ReadKey();

            //  Medoth to display header
            void ShowEmployee( string title, IEnumerable<Employee> set)
            {
                Console.WriteLine();
                Console.WriteLine(title);
                Console.WriteLine();
                Console.WriteLine($"{"#",-4}{"Name",-15}{"MonthlySalary",15:C}{"AnnualSalary",15:C}");
                Console.WriteLine($"{"--",-4}{"---------------",-15}{"-------------",15:C}{"------------",15:C}");

                var emps = set.ToArray();
                for (int i = 0; i < emps.Count(); i++)
                {
                    Console.WriteLine($"{ i + 1 + ".",-4}{emps[i].ShowEmployee()}");


            }   }
        }
    }
}
