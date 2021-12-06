using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAppII
{
    class Employee
    {
        private double _salary;

        // Constructor 
        public Employee(string n, string p, double s)
        {
            Name = n;
            Phone = p;
            MonthlySalary = s;
        }

        //Instance variables and properties
        public string Name { get; set; }

        public string Phone { get; set; }

        public double MonthlySalary
        {
            get { return _salary; }

            //Check for negative value
            set
            {
                if (value < 0)
                {
                    // throw new Exception("Salary cannot be negative value"); 
                }
                else
                {
                    _salary = value;
                }
            }
        }

        public double AnnualSalary
        {
            get
            {
                return MonthlySalary * 12;
            }
        }

        // Methods

        public void Raise()
        {
            MonthlySalary = MonthlySalary * 1.10;
        }

        public string ShowEmployee()
        {
            return $" {Name, -15}{MonthlySalary,15:C}{AnnualSalary,15:C}";
        }
    }
}
