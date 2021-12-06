using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    class Employee
    {
        //Instance variables and properties
        public string Name { get; set; }

        public string Phone { get; set; }

        private double _salary;

        public double MonthlySalary
        {
            get { return _salary; }

            //Check for negative value
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
                else
                {
                    throw new Exception("Salary cannot be negative value");
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
            MonthlySalary = MonthlySalary + (MonthlySalary * 0.10);
        }

        public string ShowEmployee()
        {
            return $" {Name}\t   {Phone}\t {MonthlySalary.ToString("C")}\t  {AnnualSalary.ToString("C")}";
        }

        // Constructor 
        public Employee(string n, string p, double s)
        {
            Name = n;
            Phone = p;
            MonthlySalary = s;
        }
    }
}
