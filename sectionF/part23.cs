//async and await program:
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Fetching data...");
        string result = await FetchDataAsync();
        Console.WriteLine("Result: " + result);
        Console.WriteLine("Program finished.");
    }
    static async Task<string> FetchDataAsync()
    {
        // simulate a delay
        await Task.Delay(3000); // 3 seconds
        return "Data fetched successfully!";
    }
}
