
using System;
using System.Collections.Generic;

abstract class Employee
{
    public string Name{ get; set;}

    public Employee(string name)
    {
        Name = name;
    }

    public abstract double CalculateSalary();
}

class FullTimeEmployee:Employee
{
    private double monthlySalary;

    public FullTimeEmployee(string name, double salary):base(name)
    {
        monthlySalary = salary;
    }

    public override double CalculateSalary()
    {
        return monthlySalary;
    }
}

class ContractEmployee:Employee
{
    private double Hours;
    private double Rate;

    public ContractEmployee(string name, double hours, double rate):base(name)
    {
        Hours = hours;
        Rate = rate;
    }

    public override double CalculateSalary()
    {
        return Hours*Rate;
    }
}

class Intern:Employee
{
    private double stipend;

    public Intern(string name, double stipend):base(name)
    {
        this.stipend = stipend;
    }

    public override double CalculateSalary()
    {
        return stipend;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new FullTimeEmployee("Ravi",50000),
            new ContractEmployee("Priya",100,300),
            new Intern("Arun",10000)
        };

        Console.WriteLine("Name    Salary");

        foreach (Employee e in employees)
        {
            Console.WriteLine($"{e.Name}    {e.CalculateSalary()}");
        }
    }
}
