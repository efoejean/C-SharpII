using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemModification
{
    class Pieceworker : Employee
    {
        private decimal _wage;
        private int _pieces;

        public Pieceworker(string firstName, string lastName,
           string socialSecurityNumber, decimal wage, int pieces) : base(firstName, lastName, socialSecurityNumber)
        {
            // implicit call to object constructor occurs here
            Wage = wage;
            Pieces = pieces;
        }

        // property that gets and sets employee wage
        public decimal Wage
        {
            get
            {
                return _wage;
            }

            set
            {
                if(value <= 0) // validate
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(Wage)} must be > 0");
                }

                _wage = value;
            }
        }


        // property that gets and sets pieces produced.
        public int Pieces
        {
            get
            {
                return _pieces;
            }

            set
            {
                if(value < 0)  // validate
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(Pieces)} must be >= 0");
                }

                _pieces = value;
            }
        }

        // calculate pieceworker employee's pay
        public override decimal Earnings() => Pieces * Wage;

        // return string representation of CommissionEmployee object
        public override string ToString() =>
        
            $"{base.ToString()}" + $" Employee Wage: {Wage:C}\n" + $"Number of pieces produced: {Pieces}";
        

    }
}
