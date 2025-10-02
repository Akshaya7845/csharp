//class and object example
using System;

namespace StudentApp
{
    class Student
    {
        public string Name;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Akshaya";
            s1.Age = 22;

            Console.WriteLine($"{s1.Name} is {s1.Age} years old.");
        }
    }
}
