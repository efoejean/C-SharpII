using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Auto
    {
        private double _cost;

        public Auto(string vin, string mm, double cost)
        {
            VIN = vin;
            Cost = cost;
            MakeModel = mm;
        }

        public string VIN { get; set; }
        public string MakeModel { get; set; }

        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value >= 0)
                {
                    _cost = value;
                }
            }
        }
        public double List
        {
            get
            {
                return  Cost * _margin;
            }

        }
        public double Profit
        {
            get
            {
                return List - Cost;
            }
        }

        public static double _margin = 1.1;
        public static double Margin
        {
            get
            {
                return _margin;
            }
            set
            {
                _margin = value;
            }
        }


        public static void IncreaseMargin()
        {
            Margin += 0.02;
        }

        public static void DecreaseMargin()
        {
            Margin -= 0.02;
        }

        public string ShowAutos()
        {
            return $"{VIN,-15}{MakeModel,15}{Cost,20:C}{List,20:C}{Profit,20:C}";
        }
    }
}
