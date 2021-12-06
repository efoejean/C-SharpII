using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Shapes
{
    class Tetrahedron
    {
        // Default constructor
        public Tetrahedron()
        {
            CurrentSize = 1;
        }

        // Constructor to accept value
        public Tetrahedron(double num)
        {
            _size = num;
        }



        // field or variable
        private double _size;

        // CurrentSize property
        public double CurrentSize
        {
            get
            {
                return _size;
            }
            set
            {
                //Validate the value
                if (value > 0)
                {
                    _size = value;
                }
                else
                {
                    throw new Exception("Size must be a positive number");
                }

            }
        }

        // SurfaceArea property
        public double SurfaceArea
        {

            get
            {
                return Math.Sqrt(3) * Math.Pow(CurrentSize,2);
            }

        }

        //Volume property
        public double Volume
        {
            get
            {
                return (1.0 / 12) * Math.Sqrt(2) * Math.Pow(CurrentSize, 3);
            }
        }

        // Methods to increase the size.
        public void Enlarge()
        {
            CurrentSize += (CurrentSize * 0.10);
        }
    }
}
