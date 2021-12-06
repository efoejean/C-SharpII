using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Auto : Vehicle
    {
     
        public double MPG { get; }
        public Auto(String name, double miles, double mpg) : base(name, miles)
        {
            MPG = mpg;
            Speed = 65;
        }

        public double Gallons { get => Miles / MPG; }

        public virtual double Cost { get => Miles / MPG * 4.00; }




    }
}
