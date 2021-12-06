using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHierarchy
{
    class SavingsAccount : Account
    {
        private decimal _interestRate;

        // Constructor
        public SavingsAccount(decimal bal, decimal inter) : base(bal)
        {
            InterestRate = inter;
        }

        public decimal InterestRate
        {
            get
            {
                return _interestRate;
            }
            set
            {
                if(value > 0)
                {
                    _interestRate = value;
                }
                else
                {
                    throw new Exception(" Interest rate must be greater than zero");
                }
            }
        }

        // Method

        public decimal CalculateInterest()
        {
           return CurrentBalance * InterestRate;
        } 
    }
}
