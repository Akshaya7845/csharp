//def example:
/*#define DEBUG

using System;

class Program
{
    static void Main()
    {
#if DEBUG
        Console.WriteLine("Debug mode ON");
#endif
    }
}*/
// undef example:

/*#define TEST      
#undef TEST       

using System;

class Program
{
    static void Main()
    {
#if TEST           
        Console.WriteLine("This won't be printed");
#endif
    }
}*/

//#if, #elif, #else, #endif – Conditional Compilation: 
/*#define RELEASE

using System;

class Program
{
    static void Main()
    {
#if DEBUG
        Console.WriteLine("Debug build");
#elif RELEASE
        Console.WriteLine("Release build");
#else
        Console.WriteLine("Unknown build");
#endif
    }
}*/
//#region and #endregion
#region StudentDetails
class Student
{
    public string name = "Akshaya";
    public int age = 22;
}

#endregion
class Program
{
    static void Main()
    {
        Student s = new Student();
        Console.WriteLine($"Name: {s.name}, Age: {s.age}");
    }
}



