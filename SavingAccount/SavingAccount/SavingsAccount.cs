using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccount
{
    class SavingsAccount
    {
        // Static properties
        public static double AnnualInterestRate { get; set; }

        //instance variables,
       private double _balance;

        //constructors
        public SavingsAccount(double bal)
        {
            SavingsBalance = bal;
        }

        public SavingsAccount()
        {
            SavingsBalance = 1000;
        }

        //properties
        public double SavingsBalance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public void CalculateMonthlyInterest()
        {
            SavingsBalance += SavingsBalance * AnnualInterestRate /12;  
        }

        public static void IncreaseRate()
        {
            AnnualInterestRate += 0.01;
        }

        public string Showbalance()
        {
            return $"{SavingsBalance,15:C}";
        }
    }
}
