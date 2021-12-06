using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class PHEV : Auto
    {


        public PHEV(String name, double miles, double mpg, double range) : base(name, miles, mpg)
        {
            Range = range;

        }

        public double Range { get; set; }


        public override double Cost { get => (Miles - Range) / MPG * 4.00; }


    }
}
