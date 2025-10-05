//thread safe singleton class
/*using System;

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
*/
//singleton with threads:
using System;
using System.Threading;
public class ATMSystem
{
    private static ATMSystem _instance;
    private static readonly object _lock = new object();

    private ATMSystem()
    {
        Console.WriteLine("ATM system started");
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
        Console.WriteLine("transactions using threads \n");

        // start 5 threads (simulating 5 users)
        for (int i = 1; i <= 5; i++)
        {
            int userId = i; // capture loop variable
            Thread thread = new Thread(() =>
            {
                ATMSystem.Instance.ProcessTransaction($"User {userId}");
            });
            thread.Start();
        }
        // wait to ensure all threads finish
        Thread.Sleep(1000);

        Console.WriteLine("\n transactions completed.");
    }
}

