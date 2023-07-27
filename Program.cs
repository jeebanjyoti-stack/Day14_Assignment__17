using System;

namespace Day_14_Assignment_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle(8);
            Rectangle rectangle = new Rectangle(8, 10);
            Triangle triangle = new Triangle(5, 6, 7);

            
            Console.WriteLine("Circle Information:");
            circle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle Information:");
            rectangle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Triangle Information:");
            triangle.PrintInfo();

            Console.ReadKey();
        }
    }
}
