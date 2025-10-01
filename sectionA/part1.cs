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

#define TEST      
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
}

