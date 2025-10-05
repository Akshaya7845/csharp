//exception handling
using System;

class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message) { }
}

class Program
{
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            // throw custom exception if age is below 18
            throw new MyCustomException("Age should be at least 18.");
        }
        else
        {
            Console.WriteLine("Age is valid.");
        }
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            CheckAge(age);
        }
        catch (MyCustomException ex)
        {
            // handle custom exception
            Console.WriteLine("Custom Error: " + ex.Message);
        }
        catch (FormatException)
        {
            // handle invalid number input
            Console.WriteLine("Please enter a valid number.");
        }
        finally
        {
            // always executed
            Console.WriteLine("Thank you for using the program!");
        }
    }
}
