using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Square : TwoDimensionalShape
    {
        public Square(string name, double size) : base(name, size)
        {

        }


        // Abstract Method
        public override double Area() => 6 * Math.Pow(base.Size, 2);

        // override ToString method
        public override string ToString() =>
        $"{base.ToString()}";

    }
}
