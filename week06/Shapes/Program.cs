using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Rectangle rectangle = new Rectangle("blue", 2, 5);
        shapes.Add(rectangle);

        Square square = new Square("black", 12);
        shapes.Add(square);

        Circle circle = new Circle("green", 3);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }


    }
}