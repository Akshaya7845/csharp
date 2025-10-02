//encapsulation
using System;

class BankAccount
{
    private double balance;
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: {amount:C}. New balance: {balance:C}");
        }
    }
    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        account.Deposit(500);       
        account.Withdraw(200);      
        account.Withdraw(400);     
        account.Deposit(-50); 

        Console.WriteLine($"Final balance: {account.GetBalance():C}");
    }
}

