//strategy pattern example:
using System;
namespace StrategyPatternExample
{ 
    public interface IDosaStrategy
    {
        void MakeDosa();
    }

    // concrete strategy 1
    public class PlainDosa : IDosaStrategy
    {
        public void MakeDosa()
        {
            Console.WriteLine("making Plain Dosa");
        }
    }

    // concrete strategy 2
    public class MasalaDosa : IDosaStrategy
    {
        public void MakeDosa()
        {
            Console.WriteLine("making Masala Dosa");
        }
    }
    public class DosaShop
    {
        private IDosaStrategy _strategy;
        public void SetStrategy(IDosaStrategy strategy)
        {
            _strategy = strategy;
        }
        public void MakeDosa()
        {
            if (_strategy == null)
            {
                Console.WriteLine("No dosa strategy selected!");
            }
            else
            {
                _strategy.MakeDosa();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DosaShop shop = new DosaShop();
            shop.SetStrategy(new PlainDosa());
            shop.MakeDosa();
            shop.SetStrategy(new MasalaDosa());
            shop.MakeDosa(); 
            Console.WriteLine("\n Done. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
