

using Fullstack_2026.registry;

var registry = new Registry();

do
{
    Console.Write("Please enter a new name: ");
    string? userInput =Console.ReadLine();
    
    if (userInput != null)
    {
        var employee = new Employee(new Name(userInput, ""), null);
        registry.AddEmployee(employee);
        Console.WriteLine(registry.GetEmployees());
    }

} while (true);