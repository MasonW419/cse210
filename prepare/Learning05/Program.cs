using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 5));
        shapes.Add(new Rectangle("red", 4, 6));
        shapes.Add(new Circle("yellow", 3));
        foreach(Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}