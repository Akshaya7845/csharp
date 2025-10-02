//const vs readonly
using System;

namespace DemoApp
{
    class Demo
    {
        // const is a compile time constant and must be initialized when declared
        public const double PI = 3.14;

        // readonly is a run time constant can only be assigned in the constructor or at declaration
        public readonly DateTime CreatedAt;

        //constructor
        public Demo()
        {
            CreatedAt = DateTime.Now;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Demo d = new Demo();

            Console.WriteLine($"Value of PI (const): {Demo.PI}"); 
            Console.WriteLine($"Object created at: {d.CreatedAt}"); 
        }
    }
}
