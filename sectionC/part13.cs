//interface example:
using System;

interface IShape
{
    double CalculateArea();
}

class Circle : IShape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : IShape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        IShape c = new Circle(5);
        Console.WriteLine("Circle Area: " + c.CalculateArea());

        IShape r = new Rectangle(4, 6);
        Console.WriteLine("Rectangle Area: " + r.CalculateArea());
    }
}
