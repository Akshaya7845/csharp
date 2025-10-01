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
/*using System;
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
}*/
// example for warning error and pragma preproceesor directives
#define TEST

using System;

class Program
{
    static void Main()
    {
        int unusedVariable = 10;  //  This will cause a warning (variable assigned but never used)

#pragma warning disable CS0219  // disable warning for unused variable
        int temp = 5;            //  don't show a warning
#pragma warning restore CS0219 // restore the warning

        Console.WriteLine("Program running...");

#if TEST
#warning This is a compiler warning message (TEST symbol is defined)
#endif

#if DEBUG
#error Debug mode not allowed in production!
#endif
    }
}



