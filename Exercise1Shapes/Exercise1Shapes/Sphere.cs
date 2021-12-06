using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Shapes
{
    class Sphere
    {
        // Default constructor
        public Sphere()
        {
            CurrentSize = 1;
        }

        // Constructor to accept value
        public Sphere(double num)
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
                return 4*Math.PI*CurrentSize*CurrentSize;
            }

        }

        //Volume property
        public double Volume
        {
            get
            {
                return (4.0/3)*Math.PI*CurrentSize*CurrentSize*CurrentSize;
            }
        }

        // Methods to increase the size.
        public void Enlarge()
        {
            CurrentSize += (CurrentSize * 0.10);
        }
    }
}
