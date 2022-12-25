using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Program
    {
        static void Main()
        {
            Triangle triangle = new Triangle("треугольник", 12, 16, 19);
            triangle.Print();
            triangle.Area();

            Console.WriteLine();

            TriangleColour triangleColour = new TriangleColour("треугольник", 12, 17, 19, 123);
            triangleColour.Area();
            triangleColour.Print();
        }
    }
}
