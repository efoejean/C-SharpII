using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemModification
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>() {
                new Employee("Biff", "Arfus", "111-11-1111"),
                new CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.00m, .06m),
                new BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00m, .04m, 300.0m),
                new Pieceworker("Joe", "Hall", "555-55-5555", 150.50m, 10)
            };


            foreach(Employee e in emps)
            {
                DisplayEmp(e);
            }


            void DisplayEmp(Employee emp)
            {
                Console.WriteLine($"{"Employee",-20}");
                Console.WriteLine($"{"Employee Name:",-20}{emp.FirstName} {emp.LastName}");
                Console.WriteLine($"{"SS#:",-20}{emp.SocialSecurityNumber}");
                Console.WriteLine($"{"Earnings:",-20}{emp.Earnings():C}");

                if(emp is CommissionEmployee)
                {
                    Console.WriteLine($"{"Gross Sales:",-20}{((CommissionEmployee)emp).GrossSales:C}");
                    Console.WriteLine($"{"Commission Rate:",-20}{((CommissionEmployee)emp).CommissionRate:P}\n");

                }
                else if (emp is BasePlusCommissionEmployee)
                {
                    Console.WriteLine($"{"Base Salary:",-20}{((BasePlusCommissionEmployee)emp).BaseSalary:C}\n");

                }
                else if(emp is Pieceworker)
                {
                    Console.WriteLine($"{"Employee Wage:",-20}{((Pieceworker)emp).Wage}");
                    Console.WriteLine($"{"Pieces produced:",-20}{((Pieceworker)emp).Pieces}\n");

                }
                else
                {
                    Console.WriteLine("\n");
                }
            }


            Console.ReadKey();
        }
    }
}
