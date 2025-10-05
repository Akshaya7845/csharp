//thread safe singleton class
using System;

public class ATMSystem
{
    private static ATMSystem _instance;
    private static readonly object _lock = new object();

    private ATMSystem()
    {
        Console.WriteLine("ATM System started");
    }

    public static ATMSystem Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ATMSystem();
                }
            }
            return _instance;
        }
    }

    public void ProcessTransaction(string user)
    {
        Console.WriteLine($"Transaction processed for {user} | ATM Instance: {this.GetHashCode()}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("ATM Transactions (Simple Test without Threads/Tasks)\n");

        ATMSystem atm1 = ATMSystem.Instance;
        ATMSystem atm2 = ATMSystem.Instance;
        atm1.ProcessTransaction("User A");
        atm2.ProcessTransaction("User B");

        // Confirm both variables point to the same instance
        Console.WriteLine("\nSame instance? " + Object.ReferenceEquals(atm1, atm2)); // True

        Console.WriteLine("\nTest completed.");
    }
}

