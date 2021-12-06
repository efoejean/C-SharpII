using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Cube("Cube", 10),
                new Sphere("Sphere", 10),
                new Circle("Circle", 10),
                new Square("Square", 10)
            };

            // Display use ForEcah
            foreach(Shape e in shapes)
            {

                if (e is TwoDimensionalShape)
                {
                    Console.WriteLine(e.ToString());
                }
                else if (e is ThreeDimensionalShape)
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine($"{"Volume: "}{((ThreeDimensionalShape)e).Volume()}"); // Casting the ThreeDimensionalShape to get the volume mothod.
                }
                else
                {
                    Console.WriteLine("\n");
                }
               
            }

            Console.ReadKey();
        }
    }
}
