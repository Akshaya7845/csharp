// var example
/*using System;
class Program
{
    static void Main()
    {
        var name = "Kumar";  

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Type of 'name': " + name.GetType());  
    }
}*/
//dynamic example:
using System;
class Program
{
    static void Main()
    {
        dynamic item = "Hello";
        Console.WriteLine("item (string): " + item);

        item = 123;
        Console.WriteLine("item (int): " + item);

        item = true;
        Console.WriteLine("item (bool): " + item);

        var x = "hello";
        Console.WriteLine("x.Length: " + x.Length);

        dynamic y = "world";
        Console.WriteLine("y.Length: " + y.Length);
    }
}

