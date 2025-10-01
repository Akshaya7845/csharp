//nullable type
using System;

class Program
{
    static void Main()
    {
        int? age = null;  //no age or if we give int? age =22 it prints 22...

        if (age.HasValue)
        {
            Console.WriteLine(age.Value);  // Prints the value if it's not null
        }
        else
        {
            Console.WriteLine("Age is not provided.");  // Output in this case
        }
    }
}
