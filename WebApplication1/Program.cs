
using System;

public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }
}

public class Manager : Employee
{
    public int Id { get; set; }
    public string Designation { get; set; }

    public Manager(int id,string name, int salary, string designation)
        : base(name, salary)
    {
        Id = id;
        Designation = designation;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Designation: {Designation}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager(200414539, "Murtaza", 80000, " senior Manager");
        manager.PrintDetails();
    }
}