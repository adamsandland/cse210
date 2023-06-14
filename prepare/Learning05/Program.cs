using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 3.0));
        shapes.Add(new Rectangle("yellow", 2.0, 4.0));
        shapes.Add(new Circle("blue", 2.0));
        foreach (var item in shapes)
        {
            Console.WriteLine($"{item.GetColor()}, {item.GetArea()}");
        }
    }
}