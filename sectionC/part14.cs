//method overloading
/*using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine(calc.Add(5, 10));
        Console.WriteLine(calc.Add(5, 10, 15));
        Console.WriteLine(calc.Add(5.5, 10.5));
    }
}
*/
//method overriding
using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal;

        myAnimal = new Dog();
        myAnimal.Speak();

        myAnimal = new Cat();
        myAnimal.Speak();
    }
}

