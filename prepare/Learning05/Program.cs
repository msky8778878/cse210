using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 1.5));
        shapes.Add(new Circle("blue", 1.5));
        shapes.Add(new Rectangle("yellow", 1.5, 2.5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }
    }
}