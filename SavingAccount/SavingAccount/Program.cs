using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating two objects
            SavingsAccount saver1 = new SavingsAccount(2000);
            SavingsAccount saver2 = new SavingsAccount(3000);

            Console.WriteLine("initail balance");
            Console.WriteLine(saver1.Showbalance());
            Console.WriteLine(saver2.Showbalance());
            Console.WriteLine();

            // Set Annual rate to 4%
            SavingsAccount.AnnualInterestRate = 0.04;

            // calculate monthly interest and add it the balance
            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();

            // Display new balance after 4% interest
            Console.WriteLine("Balance after applying 4% interest");
            Console.WriteLine( saver1.Showbalance());
            Console.WriteLine(saver2.Showbalance());
            Console.WriteLine();

            // set interest annual interest to 5%
            
            SavingsAccount.IncreaseRate();

            // calculate new month interest after set the interest rate to 5%

            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();

            Console.WriteLine("Balance after increasing interest to 5%");
            Console.WriteLine(saver1.Showbalance());
            Console.WriteLine(saver2.Showbalance());

            Console.ReadKey();
        }
    }
}
