using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHierarchy
{
    class CheckingAccount : Account
    {
        public decimal _fee;

        public CheckingAccount(decimal bal, decimal f) : base(bal)
        {
            Fee = f;
        }

        public decimal Fee
        {
            get { return _fee; }
            set
            {
                if(value > 0)
                {
                    _fee = value;
                }
                else
                {
                    throw new Exception(" Fee was invalid");
                }
            }
        }

        // Methods
        public override void Credit(decimal _amount)
        {
            base.Credit(_amount);
            CurrentBalance -= Fee;
        }

        // Method will only charge a fees is debit is successful completed.
        public override bool Debit(decimal _amount)
        {
            if (base.Debit(_amount))
            {
                CurrentBalance -= Fee;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
