//adapter example:
using System;
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
