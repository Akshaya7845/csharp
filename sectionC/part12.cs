using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Shape s1 = new Circle(5);
        Console.WriteLine("Circle Area: " + s1.CalculateArea());

        Shape s2 = new Rectangle(4, 6);
        Console.WriteLine("Rectangle Area: " + s2.CalculateArea());
    }
}
