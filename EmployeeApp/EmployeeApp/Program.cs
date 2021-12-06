using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            try //try catch to catch negative value
            {
                // Using an array initializer
                Employee[] employees =
                {

                new Employee("mary", "618-562-9632", 1000),
                new Employee("Becky", "618-753-8632", 1500),
                new Employee("Van", "314-952-9656", 2000),
                };

                //Display Array content
                ShowAllEmployee();

                // give raise, by using the raise() method from Employee class
                foreach (Employee e in employees)
                {
                    e.Raise();
                }

                //Display Array content after giving raise to employee
                Console.WriteLine(" After The Raise");
                Console.WriteLine("");
                ShowAllEmployee();

                Console.WriteLine("");
                Console.WriteLine("Press any key");

                Console.ReadKey();

                // Medoth to display all employeee
                void ShowAllEmployee()
                {
                    Console.WriteLine(" Name      Phone Number   Monthly Salary  Annual Salary");
                    Console.WriteLine("---------  -----------   ---------------  -------------");

                    // using ShowEmployee() method from Employee class to display all properties.
                    foreach (Employee e in employees)
                    {
                        Console.WriteLine(e.ShowEmployee());
                    }

                    Console.WriteLine("");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

           

        }
    }
}
