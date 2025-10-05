//thread example:
using System;
using System.Threading;

class ATMExample
{
    static void FraudCheck()
    {
        Console.WriteLine(" fraud check started...");
        Thread.Sleep(3000); 
        Console.WriteLine("no fraud detected.");
    }

    static void Main()
    {
        Console.WriteLine(" welcome to ATM!");
        Thread fraudThread = new Thread(FraudCheck);
        fraudThread.Start();
        Console.WriteLine("withdrawing cash...");
        Thread.Sleep(2000);
        Console.WriteLine("printing receipt...");

        // Wait for fraud check to finish
        fraudThread.Join();
        Console.WriteLine("transaction completed.");
    }
}
