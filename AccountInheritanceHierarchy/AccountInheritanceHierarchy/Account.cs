using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHierarchy
{
    class Account
    {
        //Instance variable
        private decimal _balance;

        
        // Constructor
        public Account (decimal bal)
        {
            CurrentBalance = bal;
        }


        // Property
        public decimal CurrentBalance
        {
            get
            {
                return _balance;
            }
            set
            {
                if(value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    _balance = 0.0M;
                    throw new Exception(" balance was invalid");
                }
            }
        }

        // Methods

        public virtual void Credit(decimal _amount)
        {
            if(_amount > 0)
            {
                CurrentBalance += _amount;
            }
            else
            {
                 throw new Exception("Amount must be greater than 0");
            }
            
        }


        // Define Account’s Debit method so that it returns a bool indicating whether money was withdrawn.
        public virtual bool Debit(decimal _amount)
        {
            bool flag = false;

            if(_amount <= CurrentBalance)
            {
                CurrentBalance -= _amount;
                flag = true;
            }
            else
            {
                CurrentBalance = _balance;
                Console.WriteLine("Debit amount resquested exceeded account balance");
                flag = false;
            }
            return flag;
        }
    }
}
