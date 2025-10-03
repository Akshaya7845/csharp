//generic class example:
using System;
using System.Collections.Generic;

namespace GenericRepositoryExample
{
    public class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Update(int index, T item)
        {
            if (index >= 0 && index < items.Count)
            {
                items[index] = item;
            }
            else
            {
                Console.WriteLine("Invalid index for update.");
            }
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index for delete.");
            }
        }

        public List<T> GetAll()
        {
            return new List<T>(items);
        }
    }

    // Sample model class
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Product [Id={Id}, Name={Name}]";
        }
    }

    class Program
    {
        static void Main()
        {
            Repository<Product> productRepo = new Repository<Product>();
            productRepo.Add(new Product { Id = 1, Name = "Laptop" });
            productRepo.Add(new Product { Id = 2, Name = "Smartphone" });
            productRepo.Update(1, new Product { Id = 2, Name = "Tablet" });
            productRepo.Delete(0);
            List<Product> products = productRepo.GetAll();

            Console.WriteLine("Current Products:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}

