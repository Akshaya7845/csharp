//method overloading
using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine(calc.Add(5, 10));
        Console.WriteLine(calc.Add(5, 10, 15));
        Console.WriteLine(calc.Add(5.5, 10.5));
    }
}
