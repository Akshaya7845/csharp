//class and object example
/*using System;

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
*/
//constructor example
/*using System;

namespace StudentApp
{
    class Student
    {
        public string Name;

        // Constructor
        public Student()
        {
            Name = "Unknown";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine(s1.Name); 
        }
    }
}
*/
//constructor chaining:
/*using System;

namespace StudentApp
{
    class Student
    {
        public string Name;
        public int Age;

        // default constructor
        public Student() : this("No Name", 0)
        {
            Console.WriteLine("default constructor called.");
        }

        // Constructor that accepts only name, sets default age
        public Student(string name) : this(name, 0)
        {
            Console.WriteLine("constructor with only name called.");
        }

        // Constructor that accepts name and age
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("parameterized constructor called.");
        }

        // Method to display student info
        public void Display()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  student using default constructor
            Student s1 = new Student();
            s1.Display(); 

            Console.WriteLine();

            //  student with name only
            Student s2 = new Student("Akshaya");
            s2.Display(); 

            Console.WriteLine();

            //  student with name and age
            Student s3 = new Student("Aishwarya", 24);
            s3.Display(); 
        }
    }
}
*/
//method overloading
using System;

namespace CalculatorApp
{
    class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Adding integers: {a} + {b} = {a + b}");
        }
        public void Add(double a, double b)
        {
            Console.WriteLine($"Adding doubles: {a} + {b} = {a + b}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add(5, 10); 
            c.Add(2.5, 3.5);  
        }
    }
}
