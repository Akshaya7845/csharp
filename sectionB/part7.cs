//partial class
using System;
public partial class Student
{
    public string Name;
}

public partial class Student
{
    public int Age;
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.Name = "Akshaya";
        s.Age = 22;
        Console.WriteLine($"{s.Name} - {s.Age}");
    }
}
