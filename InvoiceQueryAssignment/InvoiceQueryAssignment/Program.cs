using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceQueryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoices = new Invoice[]
            {
                new Invoice(83, "Electric sander", 7, 57.89m ),
                new Invoice(24 , "Power saw", 18, 99.99m ),
                new Invoice(7, "Seldge hammer", 11, 21.50m ),
                new Invoice(77, "Hammer", 76, 11.99m ),
                new Invoice(39, "Lawn mower", 3, 79.50m ),
                new Invoice(68, "Screwdriver", 106, 6.99m ),
                new Invoice(56, "Jig saw", 21, 11.00m ),
                new Invoice(3, "Wrench", 34, 7.50m ),

            };

            Console.WriteLine("All Invoice");
            showInvoices(invoices);
            Console.WriteLine();

            //Sort Invoice objects by PartDescription.

            Console.WriteLine("Invoice sort by Part Description:");
            var sortPartDescription = from i in invoices
                                      orderby i.PartDescription
                                      select i;
            
            showInvoices( sortPartDescription);

            //Sort Invoice objects by PartDescription.
            Console.WriteLine();
            Console.WriteLine("Invoice sort by Part Price:");
            var sortByPrice = from i in invoices
                              orderby i.Price
                              select i;

            showInvoices(sortByPrice);

            //Sort Invoice objects by Quantity.
            Console.WriteLine();
            Console.WriteLine("Invoice sort by Quantity:");
            Console.WriteLine();
            Console.WriteLine($"{"PartDescription",-15}{"Quantity",10}");
            Console.WriteLine($"{"--------------",-15}{"--------",10}");

            var sortByQuantity = from i in invoices
                                 orderby i.Quantity
                                 select new { i.PartDescription, i.Quantity };

            foreach(var q in sortByQuantity)
            {
                Console.WriteLine($"{ q.PartDescription,-15 }{ q.Quantity,10}");

            }



            //Sort Invoice objects by invoice Value or total of invoice.
            Console.WriteLine();
            Console.WriteLine("Invoice sort by invoice Value:");
            Console.WriteLine();
            var sortInvoiceValue = from i in invoices
                                   let Total = i.Quantity * i.Price
                                   orderby Total
                                   select new { i.PartDescription, invoiceTotal = Total};

            Console.WriteLine($"{"PartDescription",-15}{ "invoice Total",15:C}");
            Console.WriteLine($"{"---------------",-15}{"--------------",15}");

            foreach (var t in sortInvoiceValue)
            {
                Console.WriteLine($"{t.PartDescription,-15} {t.invoiceTotal,12}");
            }



            // Invoice total range between 200 and 500.
            Console.WriteLine();
            var invoiceRange = from i in sortInvoiceValue
                               where i.invoiceTotal >= 200 && i.invoiceTotal <= 500
                               select i.invoiceTotal;

            Console.WriteLine("Invoice range");
            Console.WriteLine("-------------");

            foreach (var r in invoiceRange)
            {
                Console.WriteLine(r.ToString() ); 
            }





            Console.ReadKey();

            void showInvoices(IEnumerable<Invoice> set)
            {
                Console.WriteLine();
                
                Console.WriteLine($"{"PartNumber",-15}{"PartDescription",-15}{"Quantity",10}{ "Price",10:C}");
                Console.WriteLine($"{"----------",-15}{"---------------",-15}{"--------",10}{"------",10}");

                foreach(Invoice i in set)
                {
                    Console.WriteLine(i.ToString());
                }

            }
        }
    }
}
