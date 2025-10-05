//thread example:
/*using System;
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
*/
//task/tpl example:
using System;
using System.Threading.Tasks;
class FoodDeliveryApp
{
    static async Task PlaceOrderAsync()
    {
        Console.WriteLine("order placed");
        await Task.Delay(1000);
        var restaurantTask = NotifyRestaurantAsync();
        var paymentTask = VerifyPaymentAsync();
        var mapTask = UpdateMapAsync();
        await Task.WhenAll(restaurantTask, paymentTask, mapTask);
        Console.WriteLine("order confirmed and being prepared.");
    }

    static async Task NotifyRestaurantAsync()
    {
        await Task.Delay(1500);
        Console.WriteLine(" restaurant notified");
    }
    static async Task VerifyPaymentAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("payment Verified");
    }
    static async Task UpdateMapAsync()
    {
        await Task.Delay(800);
        Console.WriteLine("map Updated with delivery Route");
    }
    static async Task Main()
    {
        Console.WriteLine("opening Food Delivery App...");
        await PlaceOrderAsync();
        Console.WriteLine("rider Assigned. order is on the way!");
    }
}
