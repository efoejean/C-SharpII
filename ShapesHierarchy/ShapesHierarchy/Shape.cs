using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    public abstract class Shape
    {
        // Property
        public string Name { get; }
        public double Size { get; }

        // Custructor
        public Shape ( string name, double size) 
        {
            Name = name;
            Size = size;
        }

       // abstract Area Method
        public abstract double Area();

        // override ToString method
        public override string ToString() =>
            $"\nShape: {Name}\n" +
            $"Area: {Area()}";

    }
}
