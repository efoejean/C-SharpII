using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal interest;
            try
            {
                SavingsAccount mySaving = new SavingsAccount(1000M, 0.02M);
                CheckingAccount myChecking = new CheckingAccount(2000M, 6.0M);
            
                Console.WriteLine("SAVING ACCOUNT");
                interest = mySaving.CalculateInterest();         // calculate interest
                Console.WriteLine();
                Console.WriteLine($"The available balance is {mySaving.CurrentBalance:C}");
                Console.WriteLine();
                Console.WriteLine($" The interest  is {interest:C}");
                Console.WriteLine();
                mySaving.Credit(interest);  // add the interest to the balance

                Console.WriteLine($"The new available balance is {mySaving.CurrentBalance:C}");
                Console.WriteLine();

                // Checking Account
                Console.WriteLine("CHECKING ACCOUNT");
                Console.WriteLine();
                Console.WriteLine($"The available balance  is {myChecking.CurrentBalance:C}");
                // Credit the account
                myChecking.Credit(100M); // Add 100 to the account but it will charge a fee.
                Console.WriteLine();
                Console.WriteLine($" The new available balance after deposit is {myChecking.CurrentBalance:C}");
                myChecking.Debit(200M); // Debit 200 from the account but it will charge a fee.
                Console.WriteLine();
                Console.WriteLine($" The new available balance after Debit is {myChecking.CurrentBalance:C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();


        }
    }
}
