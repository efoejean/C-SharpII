using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Shapes
{
    class Cube
    {
        // Default constructor
        public Cube()
        {
            CurrentSize = 1;
        }

        // Constructor to accept value
        public Cube(double num)
        {
            _size = num; // use the property (currentSize) not the variable _size.
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
                if(value > 0)
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
                return 6 * Math.Pow(CurrentSize, 2);
            }
           
        }

        //Volume property
        public double Volume
        {
            get
            {
                return Math.Pow(CurrentSize, 3);
            }
        }

        // Methods to increase the size.
        public void Enlarge()
        {
            CurrentSize += ( CurrentSize * 0.10);
        }

       
    }
}
