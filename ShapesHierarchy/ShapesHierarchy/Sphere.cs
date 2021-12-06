using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Sphere : ThreeDimensionalShape
    {
   
        // Constructor to accept value
        public Sphere(string name,double size): base(name, size)
        {
           
        }


        // Abstract Area Method 
        public override double Area() => 4 * Math.PI * Math.Pow(base.Size, 2);


        // Abstract Volume Method 
        public override double Volume()=> (4.0 / 3) * Math.PI * Math.Pow(base.Size, 3);


        // override ToString method
        public override string ToString() =>
        $"{base.ToString()}";
    }
}

