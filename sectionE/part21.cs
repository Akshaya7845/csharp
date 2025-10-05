//LINQ example:
using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id=1, Name="Akshaya", Department="IT", Salary=60000 },
            new Employee { Id=2, Name="Divya", Department="HR", Salary=45000 },
            new Employee { Id=3, Name="Jacky", Department="IT", Salary=70000 },
            new Employee { Id=4, Name="Harini", Department="Finance", Salary=50000 },
            new Employee { Id=5, Name="Lathangi", Department="HR", Salary=55000 },
        };

        // 1. Filter: Employees with salary > 50,000
        var filteredEmployees = employees.Where(e => e.Salary > 50000);
        Console.WriteLine("Filtered Employees (Salary > 50000):");
        foreach (var emp in filteredEmployees)
        {
            Console.WriteLine($"{emp.Name} - {emp.Salary}");
        }

        Console.WriteLine("\n-----------------------------------\n");

        // 2. Group By: Group employees by Department
        var groupedByDepartment = employees.GroupBy(e => e.Department);
        Console.WriteLine("Employees Grouped by Department:");
        foreach (var group in groupedByDepartment)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach (var emp in group)
            {
                Console.WriteLine($"  {emp.Name}");
            }
        }

        Console.WriteLine("\n-----------------------------------\n");

        // 3. Order By: Employees ordered by Salary descending
        var orderedBySalaryDesc = employees.OrderByDescending(e => e.Salary);
        Console.WriteLine("Employees Ordered by Salary (Descending):");
        foreach (var emp in orderedBySalaryDesc)
        {
            Console.WriteLine($"{emp.Name} - {emp.Salary}");
        }

        Console.WriteLine("\n-----------------------------------\n");

        // 4. Select: Only Name and Salary
        var selectedFields = employees.Select(e => new { e.Name, e.Salary });
        Console.WriteLine("Selected Employee Name and Salary:");
        foreach (var emp in selectedFields)
        {
            Console.WriteLine($"{emp.Name} - {emp.Salary}");
        }
    }
}
