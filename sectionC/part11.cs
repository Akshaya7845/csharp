//virtual example:
using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks...");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks!");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Animal();
        a1.Speak();

        Animal a2 = new Dog();
        a2.Speak();

        Animal a3 = new Cat();
        a3.Speak();

        Dog d = new Dog();
        d.Speak();
    }
}
