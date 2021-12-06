using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autos = new List<Auto>
            {
                new Auto("7JDUE736SJDMKIDHS", "Honda Civic", 11800),
                new Auto("3KFKLSO93MN4K3H2D", "Jeep Liberty", 22000),
                new Auto("2DKSLU93K2KDIUSKR", "Ford Taurus", 22500),
                new Auto("0KS73HSMJFHCGEGS2", "Saturn Ion 2", 6375),
                new Auto("111JDISLANEUS3203", "Chevrolet Chevelle SS", 5400),
                new Auto("2K394DJSLIDJSN45K", "Honda Civic", 2900),
                new Auto("LK45JMDNABBE4IWKE", "Jaguar", 2330),
                new Auto("9OUEIWJQNSJRUE3J1", "Dodge Nitro SXT", 22740),
                new Auto("66KD3849DJ7WY3HWS", "Honda Civic", -3782),
                new Auto("JJKW45NCBXVSLO3WS", "Ford Taurus", 2120)
            };




            var ShowDistinct = (from a in autos select a.MakeModel).Distinct();
            Console.WriteLine("Distinct make/models");

            foreach(var s in ShowDistinct)
            {
                Console.WriteLine(s);
            }

            
            Console.WriteLine();

            //Show the prices of all autos having the make/model of the first auto
            var firstAuto = ShowDistinct.First();


            var ShowPrices = from e in autos
                             where e.MakeModel.Equals(firstAuto)
                             select e.ShowAutos();


            foreach (var s in ShowPrices)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();


            //Show the number of autos and the average list price of the autos

             Console.WriteLine($"Average List price: { (from e in autos where e.MakeModel.Equals(firstAuto) select e.List).Average()}");

            int NumOfAuto = ShowPrices.Count();

           

            Console.WriteLine(NumOfAuto);

           

            //

            var lastItem = (from e in autos

                            where e.MakeModel.Equals(firstAuto)

                            select e).Last();

            autos.Remove(lastItem);

            autos.Insert(0, lastItem);



            ShowAut("All Autos before increasing Margin", autos);

            Auto.IncreaseMargin();


            ShowAut("All Autos After increasing Margin", autos);

            Auto.DecreaseMargin();
            ShowAut("All Autos after decreasing Margin", autos);

            Console.ReadKey();


            //  Medoth to display header
            void ShowAut(string title, IEnumerable<Auto> set)
            {
                Console.WriteLine();
                Console.WriteLine(title);
                Console.WriteLine();
                Console.WriteLine($"{"VIN",-15}{"MakeModel",20}{"Cost",20}{"List",20}{"Profit",20}");
                Console.WriteLine($"{"---------------",-15}{"---------------",15}{"-------------",15:C}{"------------",15:C}");

                var Auts = set.ToArray();
                for (int i = 0; i < Auts.Count(); i++)
                {
                    Console.WriteLine($"{ i + 1 + ".",-4}{Auts[i].ShowAutos()}");


                }
            }
        }
    }
}
