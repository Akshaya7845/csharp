//subscriber - observer example:
using System;
using System.Collections.Generic;
namespace ObserverPatternExample
{
    public interface IObserver
    {
        void Update(float temperature);
    }
    public interface ISubject
    {
        void Attach(IObserver observer);   
        void Detach(IObserver observer);   
        void Notify();                     
    }
    //publisher
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine(" observer added.");
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
            Console.WriteLine("observer removed.");
        }

        public void SetTemperature(float newTemperature)
        {
            temperature = newTemperature;
            Console.WriteLine($"\ntemperature updated to {temperature}°C");
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }
    //subscriber 1
    public class MobileDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Mobile Display: Temperature is {temperature}°C");
        }
    }
    //subscriber 2
    public class NewsDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"News Display: Breaking! Temp is {temperature}°C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();

            // create observers
            MobileDisplay mobile = new MobileDisplay();
            NewsDisplay news = new NewsDisplay();
            station.Attach(mobile);
            station.Attach(news);
            station.SetTemperature(30.5f);
            station.SetTemperature(32.0f);
            station.Detach(news);
            station.SetTemperature(29.3f);

            Console.WriteLine("\nProgram finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
