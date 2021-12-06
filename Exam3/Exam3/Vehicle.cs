using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    public class Vehicle
    {

        private double _miles;
    

        public string Name { get; }

        public virtual double Speed { get; set; }


        public Vehicle (String name, double miles)
        {
            Name = name;
           
            Miles = miles;

        }

        // Property
  

        public double Miles
        {
            get
            {
                return _miles;
            }
            set
            {
                if (value >= 0)
                {
                    _miles = value;
                }
                else
                {

                    throw new Exception(" balance was invalid");
                }
            }
        }


        public double Hours { get => Miles / Speed; }











    }
}
