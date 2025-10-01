#define DEBUG

using System;

class Program
{
    static void Main()
    {
#if DEBUG
        Console.WriteLine("Debug mode ON");
#endif
    }
}
//happy happy 
