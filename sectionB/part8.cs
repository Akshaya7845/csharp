//aceess modifiers
//public
using System;

class Demo
{
    public string name = "Akshaya";
}

class Program
{
    static void Main(string[] args)
    {
        Demo d = new Demo();
        Console.WriteLine(d.name); 
    }
}
