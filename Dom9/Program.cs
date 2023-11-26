using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary:C}");
    }

    public virtual double CalculateAnnualSalary()
    {
        return Salary * 12;
    }
}

class Manager : Employee
{
    public double Bonus { get; set; }

    public Manager(string name, int age, double salary, double bonus)
        : base(name, age, salary)
    {
        Bonus = bonus;
    }

    public override double CalculateAnnualSalary()
    {
        return base.CalculateAnnualSalary() + Bonus;
    }
}

class Developer : Employee
{
    public int LinesOfCodePerDay { get; set; }

    public Developer(string name, int age, double salary, int linesOfCodePerDay)
        : base(name, age, salary)
    {
        LinesOfCodePerDay = linesOfCodePerDay;
    }

    public override double CalculateAnnualSalary()
    {
        return base.CalculateAnnualSalary() + (LinesOfCodePerDay * 20); 
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager("John Doe", 35, 60000, 5000);
        Developer developer = new Developer("Alice Smith", 28, 55000, 1000);

        Console.WriteLine("Manager Information:");
        manager.GetInfo();
        Console.WriteLine($"Annual Salary: {manager.CalculateAnnualSalary():C}");

        Console.WriteLine("Developer Information:");
        developer.GetInfo();
        Console.WriteLine($"Annual Salary: {developer.CalculateAnnualSalary():C}");
    }
}
