List<Employee> employees = [];

while (true)
{
    Console.WriteLine("Enter your name:");
    string name = Console.ReadLine() ?? "Unknown";
    Console.WriteLine("Enter your position:");
    string position = Console.ReadLine() ?? "Unknown";
    Guid id = Guid.Empty;

    var employee = new Employee(id, name, position);
    if (employees.Contains(employee))
    {
        Console.WriteLine("Employee already exists in the list.");
        continue;
    }
    else
    {
        employees.Add(employee);
        Console.WriteLine(employee + " added to the list.");
    }

    Console.WriteLine("Enter 'exit' to quit, 'copy' to clone this employee, or press Enter to continue...");
    string? input = Console.ReadLine();
    if (input?.ToLower() == "exit")
    {
        break;
    }
    else if (input?.ToLower() == "copy")
    {
        var clonedEmployee = employee with { Id = Guid.NewGuid() };
        employees.Add(clonedEmployee);
        Console.WriteLine(clonedEmployee + " cloned and added to the list.");
    }
    else
    {
        Console.WriteLine("Continuing...");
    }
}

record Employee(Guid Id, string Name, string Position)
{
    public override string ToString() => $"{Id} - {Name} - {Position}";
}