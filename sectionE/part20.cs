//ienumerator without yield return:
/*using System;
using System.Collections;
using System.Collections.Generic;

class StudentCollection : IEnumerable<string>
{
    private string[] students = { "Anbu", "Divya", "Karthik", "Meena" };

    public IEnumerator<string> GetEnumerator()
    {
        return new StudentEnumerator(students);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class StudentEnumerator : IEnumerator<string>
{
    private string[] _students;
    private int position = -1;

    public StudentEnumerator(string[] students)
    {
        _students = students;
    }

    public string Current => _students[position];

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        position++;
        return position < _students.Length;
    }

    public void Reset()
    {
        position = -1;
    }

    public void Dispose()
    {
        // No resources here
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("using manual IEnumerator implementation:");
        var manualCollection = new StudentCollection();
        foreach (var student in manualCollection)
        {
            Console.WriteLine(student);
        }
    }
}
*/
//ienumerator using yield return example
using System;
using System.Collections.Generic;

class YieldStudentCollection
{
    private string[] students = { "Anbu", "Divya", "Karthik", "Meena" };

    public IEnumerable<string> GetStudents()
    {
        foreach (var student in students)
        {
            yield return student;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Using yield return Implementation:");
        var yieldCollection = new YieldStudentCollection();
        foreach (var student in yieldCollection.GetStudents())
        {
            Console.WriteLine(student);
        }
    }
}
