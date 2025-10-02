//partial class
/*using System;
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
*/
//partial method
using System;
public partial class Student
{
    public void Init()
    {
        OnInit(); // partial method call
    }
    partial void OnInit();
}

public partial class Student
{
    // implementation of the partial method
    partial void OnInit()
    {
        Console.WriteLine("Student Initialized");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.Init(); 
    }
}
