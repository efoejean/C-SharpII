using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamI
{
    class Auto
    {
        //Instance variables and properties

        double _cost;

        public string Vin { get; set; }

        public string MakeModel { get; set; }

        public double Cost
        {
            get { return _cost; }

            set
            {
                if (value < 0)
                {
                   // throw new Exception("Cost cannot be negative ");

                }
                else
                {
                    _cost = value;
                }
            }
        }

        public double ListPrice
        {
            get
            {
                return Cost * 1.10;

            }
           
        }
       public double Profit
        {
            get
            {
                return ListPrice - Cost;
            }
        }

        // Constructor
        public Auto(string v, string m, double c)
        {
            Vin = v;
            MakeModel = m;
            Cost = c;

        }
        public string showAuto()
        {
            return $" {Vin,-20}{MakeModel,-40}{Cost,-20:C}{ListPrice,-20:c}{Profit,-20:C}";
        }
    }
}
