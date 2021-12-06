using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Circle: TwoDimensionalShape
    {
        public Circle(string name, double size) : base(name, size)
        {

        }

       // abstract Area Method
        public override double Area() => Math.PI * Math.Pow(base.Size, 2);

        // override ToString method
        public override string ToString() =>
        $"{base.ToString()}";

    }
}
