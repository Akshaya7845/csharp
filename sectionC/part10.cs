//inheritance example
using System;
class Vehicle
{
    public string brand;

    public void ShowBrand()
    {
        Console.WriteLine("Brand: " + brand);
    }
}
class Car : Vehicle
{
    public int numberOfDoors;

    public void ShowCarDetails()
    {
        Console.WriteLine("Car with " + numberOfDoors + " doors");
    }
}
class Bike : Vehicle
{
    public bool hasCarrier;

    public void ShowBikeDetails()
    {
        Console.WriteLine("Bike has carrier: " + hasCarrier);
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.brand = "Toyota";
        myCar.numberOfDoors = 4;
        myCar.ShowBrand();          
        myCar.ShowCarDetails();

        Bike myBike = new Bike();
        myBike.brand = "Hero";
        myBike.hasCarrier = true;
        myBike.ShowBrand();          
        myBike.ShowBikeDetails();
    }
}
