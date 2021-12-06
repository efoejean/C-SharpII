using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle[] vehicles =
            {

                new Bicycle("Bicycle",60,150),
                new PHEV("Chev Volt",60, 40, 39),
                new Auto("Cadillac", 60, 20),
            };

            Console.WriteLine($"{"Name",-15}{"Hours",15}{"Gallons",15}{"Cost",15}");

            foreach ( Vehicle v in vehicles)
            {
                if(v is Auto)
                {
                    Console.WriteLine($"{v.Name,-15} {v.Hours,15:F} {((Auto)v).Gallons,10:F} {((Auto)v).Cost,15:C}" );
                }
                else
                {
                    Console.WriteLine($"{v.Name,-15} {v.Hours,15:F}");
                }
            }

            Console.ReadKey();
        }
    }
}
