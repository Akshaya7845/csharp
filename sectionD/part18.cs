using System;

class Program
{
    // delegate define
    public delegate void PrintMessage();

    // base method
    public static void BaseMessage()
    {
        Console.WriteLine("This is the base message.");
    }

    // Overriding-like method 1
    public static void OverrideMessage1()
    {
        Console.WriteLine("This is the first override message.");
    }

    // Overriding-like method 2
    public static void OverrideMessage2()
    {
        Console.WriteLine("This is the second override message.");
    }

    static void Main()
    {
        PrintMessage print;

        // assign base method
        print = BaseMessage;
        print();  

        // override by assigning new method 1
        print = OverrideMessage1;
        print(); 

        // override by assigning new method 2
        print = OverrideMessage2;
        print(); 
    }
}
