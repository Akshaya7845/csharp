//value type example
using System;
class Program
{
    static void Main()
    {
        int a = 10;
        int b = a;  //copy value a to b
        b = 20;     // change  b

        Console.WriteLine("Value of a: " + a);
        Console.WriteLine("Value of b: " + b);  
    }
}
