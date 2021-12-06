using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    abstract class ThreeDimensionalShape : Shape
    {
        public ThreeDimensionalShape (string name, double size) : base(name, size)
        {

        }

        // Abstract Area Method 
        public abstract override double Area();

        // Abstract Volume Method 
        public abstract double Volume();


        // override ToString method
        public override string ToString() => $"{base.ToString()}";
    }
}
