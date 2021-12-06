using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamI
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] autos =
            {
            new Auto("3KFKLSO93MN4K3H2D", "2010 Jeep Liberty", 22000),
            new Auto("2DKSLU93K2KDIUSKR", "2007 Ford F150 XLT", 22500),
            new Auto("7JDUE736SJDMKIDHS", "2004 Cadillac DeVille", 11800),
            new Auto("0KS73HSMJFHCGEGS2", "2006 Saturn Ion 2", 6375),
            new Auto("111JDISLANEUS3203", "1970 Chevrolet Chevelle SS", 5400),
            new Auto("2K394DJSLIDJSN45K", "2002 Honda Civic", 2900),
            new Auto("LK45JMDNABBE4IWKE", "1994 Jaguar", 2330),
            new Auto("9OUEIWJQNSJRUE3J1", "2010 Dodge Nitro SXT", 22740),
            new Auto("66KD3849DJ7WY3HWS", "2000 Pontiac Firebird", -3782),
            new Auto("JJKW45NCBXVSLO3WS", "1999 Ford Taurus", 2120),
            };


            Console.WriteLine("All Auto: ");
            ShowHeader();

            // variables

            int i;
           

            // Loop to display a number list of Auto
            for (i = 0; i < autos.Count(); i++)
            {
                int id = i + 1;

                Console.WriteLine($"{id}.{autos[i].showAuto()}");
            }

            Console.WriteLine();


            //Display hearder
            Console.WriteLine("Auto with a list price  at or bellow $10,000.00");
            ShowHeader();

            // declare a variable for target price
            double targetPrice = 10000;

            Auto result = null; //Flag variable

            //Loop to display Salarie over $1500

            for ( i = 0; i < autos.Count(); i ++)
            {
                int id = i +1;
                
                if (autos[i].ListPrice <= targetPrice)
                {
                    result = autos[i];
                    
                    Console.WriteLine($"{id}.{autos[i].showAuto()}");
                   
                }
            }
            if(result == null)
            {
                Console.WriteLine("Not found");
            }

            Console.ReadKey();


            void ShowHeader()
            {
                Console.WriteLine($"{"#",-4}{"Vin",-20}{"MakeModel",-40}{"Cost",-20:C}{"Price",-20:c}{"Profit",-20:C}"); 
                Console.WriteLine($"{"--",-4}{"-----------------",-20}{"-------------",-40}{"------------",-20:C}{"------------",-20:C}{"------------",-20:C}");

                Console.WriteLine();
            }
        }
    }
}
