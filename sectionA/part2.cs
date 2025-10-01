//value type example
/*using System;
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
}*/
//reference type
using System;

class Person
{
    public string Name;
}

class Program
{
    static void Main()
    {
        Person p1 = new Person();
        p1.Name = "Kumar";

        Person p2 = p1;
        p2.Name = "Ravi";

        Console.WriteLine(p1.Name);  // Output: Ravi
    }
}

