//adapter example:
/*using System;
public interface ICharger
{
    void Charge();
}
public class USBCharger
{
    public void ConnectWithUSB()
    {
        Console.WriteLine("Charging using USB-C port.");
    }
}
public class ChargerAdapter : ICharger
{
    private readonly USBCharger _usbCharger;

    public ChargerAdapter(USBCharger usbCharger)
    {
        _usbCharger = usbCharger;
    }

    public void Charge()
    {
        _usbCharger.ConnectWithUSB();
    }
}
class Program
{
    static void Main()
    {
        ICharger charger = new ChargerAdapter(new USBCharger());
        charger.Charge();
    }
}
*/
//facade example:
using System;
public class Kitchen
{
    public void CookFood(string dish)
    {
        Console.WriteLine($"Cooking {dish}...");
    }
}

public class Billing
{
    public void GenerateBill(decimal amount)
    {
        Console.WriteLine($"Bill generated: {amount}");
    }
}

public class Cleaning
{
    public void CleanTable()
    {
        Console.WriteLine("Table cleaned.");
    }
}
public class WaiterFacade
{
    private readonly Kitchen _kitchen = new();
    private readonly Billing _billing = new();
    private readonly Cleaning _cleaning = new();

    public void ServeCustomer(string dish, decimal price)
    {
        _kitchen.CookFood(dish);
        _billing.GenerateBill(price);
        _cleaning.CleanTable();
        Console.WriteLine("Order served successfully!");
    }
}
class Program
{
    static void Main()
    {
        WaiterFacade waiter = new();
        waiter.ServeCustomer("Masala Dosa", 120);
    }
}
