//singleton design pattern:
using System;
class IdGenerator
{
    private static IdGenerator _instance;
    private static readonly object _lock = new object();
    private IdGenerator()
    {
        Console.WriteLine("ID Generator system started");
    }
    public static IdGenerator Instance
    {
        get
        {
            if (_instance == null) // First check (not thread-safe)
            {
                lock (_lock) // Lock for thread safety
                {
                    if (_instance == null) // Second check (thread-safe)
                    {
                        _instance = new IdGenerator(); // create instance
                    }
                }
            }
            return _instance; // Return the same instance
        }
    }
    public void GenerateId(string citizenName)
    {
        Console.WriteLine($"Unique ID generated for {citizenName}");
    }
}
class Program
{
    static void Main()
    {
        IdGenerator dept1 = IdGenerator.Instance;
        IdGenerator dept2 = IdGenerator.Instance;
        dept1.GenerateId("Akshaya");
        dept2.GenerateId("Aishwarya");
        Console.WriteLine("\nIs it the same instance? " + Object.ReferenceEquals(dept1, dept2)); 
    }
}
