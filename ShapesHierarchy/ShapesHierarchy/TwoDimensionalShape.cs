using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    abstract class  TwoDimensionalShape : Shape
    {
        public TwoDimensionalShape(string name, double size): base (name, size)
        {

        }

        public abstract override double Area();


        // override ToString method
        public override string ToString() => $"{base.ToString()}";

    }
}
