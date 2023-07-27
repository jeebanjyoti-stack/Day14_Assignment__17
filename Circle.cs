using System;

namespace Day_14_Assignment_17
{
    internal class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            ShapeType = "Circle";
            Radius = radius;
        }

        public override double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public override double Perimeter
        {
            get { return 2 * Math.PI * Radius; }
        }
    }
}
