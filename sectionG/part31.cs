//repository ad unit of work example 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
}
public class OrderItem
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
public interface IRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task AddAsync(T entity);
    void Update(T entity);
    void Remove(T entity);
}
public class OrderRepository : IRepository<Order>
{
    private readonly List<Order> _orders = new List<Order>();
    private int _nextId = 1;

    public Task AddAsync(Order entity)
    {
        entity.Id = _nextId++;
        _orders.Add(entity);
        return Task.CompletedTask;
    }
    public Task<List<Order>> GetAllAsync()
    {
        return Task.FromResult(_orders.ToList());
    }
    public Task<Order> GetByIdAsync(int id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        return Task.FromResult(order);
    }
    public void Remove(Order entity)
    {
        _orders.Remove(entity);
    }
    public void Update(Order entity)
    {
        var existing = _orders.FirstOrDefault(o => o.Id == entity.Id);
        if (existing != null)
        {
            existing.CustomerName = entity.CustomerName;
            existing.OrderDate = entity.OrderDate;
            existing.Items = entity.Items;
        }
    }
}
public interface IUnitOfWork : IDisposable
{
    IRepository<Order> Orders { get; }
    Task CommitAsync();
}
public class UnitOfWork : IUnitOfWork
{
    private readonly OrderRepository _orderRepository = new OrderRepository();

    public IRepository<Order> Orders => _orderRepository;

    public Task CommitAsync()
    {
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        // No
    }
}
class Program
{
    static async Task Main(string[] args)
    {
        using IUnitOfWork uow = new UnitOfWork();
        var order = new Order
        {
            CustomerName = "Bob",
            OrderDate = DateTime.Now,
            Items = new List<OrderItem>
            {
                new OrderItem { ProductName = "Pen", Quantity = 10, UnitPrice = 1.5m },
                new OrderItem { ProductName = "Notebook", Quantity = 5, UnitPrice = 3.0m }
            }
        };
        await uow.Orders.AddAsync(order);
        await uow.CommitAsync();
        Console.WriteLine($"Order Added with Id = {order.Id}");
        var fetchedOrder = await uow.Orders.GetByIdAsync(order.Id);
        Console.WriteLine($"Fetched Order Id={fetchedOrder.Id}, Customer={fetchedOrder.CustomerName}");
        foreach (var item in fetchedOrder.Items)
        {
            Console.WriteLine($"  Item: {item.ProductName}, Qty: {item.Quantity}, Price: {item.UnitPrice}");
        }
    }
}


