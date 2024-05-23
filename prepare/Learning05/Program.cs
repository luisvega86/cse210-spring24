using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square(4.00, "red");
        shapes.Add(s1);
        // Console.WriteLine(s1.GetColor());
        // Console.WriteLine(s1.GetArea());

        Rectangle r1 = new Rectangle(2.0, 3.5, "yellow");
        shapes.Add(r1);
        // Console.WriteLine(r1.GetColor());
        // Console.WriteLine(r1.GetArea());

        Circle c1 = new Circle(3.0, "blue");
        shapes.Add(c1);
        // Console.WriteLine(c1.GetColor());
        // Console.WriteLine(c1.GetArea());
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}