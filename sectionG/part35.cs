using System;
using System.Collections.Generic;
public class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public int CompareTo(Student other)
    {
        return this.Marks - other.Marks;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Marks = 85 },
            new Student { Name = "Bob", Marks = 90 },
            new Student { Name = "Charlie", Marks = 75 }
        };
        students.Sort();
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name}: {student.Marks}");
        }
    }
}
