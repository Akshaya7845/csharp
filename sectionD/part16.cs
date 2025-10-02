//delegates math operation:
using System;

class Program
{
    public delegate int MathOperation(int a, int b);

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        return b != 0 ? a / b : 0;
    }

    static void Main()
    {
        MathOperation op;

        op = Add;
        Console.WriteLine("Add: " + op(10, 5));

        op = Subtract;
        Console.WriteLine("Subtract: " + op(10, 5));

        op = Multiply;
        Console.WriteLine("Multiply: " + op(10, 5));

        op = Divide;
        Console.WriteLine("Divide: " + op(10, 5));
    }
}
