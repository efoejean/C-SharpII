using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Cube : ThreeDimensionalShape
    {


        // Constructor using the Base
        public Cube(string name, double size) : base (name, size)
        {
             
        }


        // abstract Area Method
        public override double Area() => 6 * Math.Pow(base.Size, 2);


        // Abstract Volume Method 
        public override double Volume() => Math.Pow(base.Size, 3);

        // override ToString method
        public override string ToString() =>
        $"{base.ToString()}";
    }
}
