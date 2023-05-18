using System;

class Employee
{
    public int Id { get; set; }
    public string Emri { get; set; }
    public string Pozita { get; set; }
    public decimal Rroga { get; set; }

    public virtual decimal CalculateBonus(decimal rroga)
    {
        return 0;
    }
}

class Zhvillues : Employee
{
    public override decimal CalculateBonus(decimal rroga)
    {
        decimal bonus = Math.Max(50000, rroga * 0.2m);
        return bonus;
    }
}

class Menaxher : Employee
{
    public override decimal CalculateBonus(decimal rroga)
    {
        decimal bonus = Math.Max(50000, rroga * 0.25m);
        return bonus;
    }
}

class Admin : Employee
{
    public override decimal CalculateBonus(decimal rroga)
    {
        return 50000;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the type of worker (Zhvillues, Menaxher, or Admin): ");
        string workerType = Console.ReadLine();

        Employee employee;

        switch (workerType.ToLower())
        {
            case "zhvillues":
                employee = new Zhvillues();
                break;
            case "menaxher":
                employee = new Menaxher();
                break;
            case "admin":
                employee = new Admin();
                break;
            default:
                Console.WriteLine("Invalid worker type!");
                return;
        }

        Console.WriteLine("Enter employee details:");
        Console.Write("Id: ");
        employee.Id = int.Parse(Console.ReadLine());
        Console.Write("Emri: ");
        employee.Emri = Console.ReadLine();
        Console.Write("Pozita: ");
        employee.Pozita = Console.ReadLine();
        Console.Write("Rroga: ");
        employee.Rroga = decimal.Parse(Console.ReadLine());

        decimal bonus = employee.CalculateBonus(employee.Rroga);

        Console.WriteLine("Employee details:");
        Console.WriteLine($"Id: {employee.Id}");
        Console.WriteLine($"Emri: {employee.Emri}");
        Console.WriteLine($"Pozita: {employee.Pozita}");
        Console.WriteLine($"Rroga: {employee.Rroga}");
        Console.WriteLine($"Bonus: {bonus}");
    }
}
