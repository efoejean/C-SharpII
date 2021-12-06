using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollApp
{
    class SalariedEmployee : Employee
    {

        public SalariedEmployee(string firstName, string lastName,
           string socialSecurityNumber, decimal salarie) : base(firstName, lastName, socialSecurityNumber)
        {
            WeekSalary = salarie;
        }


        public decimal WeekSalary { get; set; }

        public override decimal Earnings() => WeekSalary;

        public override string ToString() =>
        $"{base.ToString()}" +
        $"Week Salary:: {WeekSalary:C}\n";

    }
}
