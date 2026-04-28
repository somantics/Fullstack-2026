
namespace Fullstack_2026.registry;

internal class CLIClient
{
    /*
    Command line interface responsible for talking to data structure and printing things pretty.

    Just a simple while loop w. a switch statement to determine which command is being inputted. 
    */
    private const string CommandPrompt = "Enter command: ";
    private Registry registry;
    private bool running = true;

    public CLIClient()
    {
        registry = new Registry();
    }


    public void Run()
    {
        WelcomeUser();
        do
        {
            Console.WriteLine();
            Console.Write(CommandPrompt);
            string? userInput = Console.ReadLine();
            if (userInput == null) break;

            var arguments = userInput.Split();
            switch (arguments.First().ToLower())
            {
                case "help":
                    PrintHelp();
                break;
                case "h":
                    PrintHelp();
                break;
                case "add":
                    AddEmployee(arguments.Skip(1).ToArray());
                break;
                case "a":
                    AddEmployee(arguments.Skip(1).ToArray());
                break;
                case "remove":
                    RemoveEmployee(arguments.Skip(1).ToArray());
                break;
                case "rm":
                    RemoveEmployee(arguments.Skip(1).ToArray());
                break;
                case "drop":
                    DropRegistry();
                break;
                case "d":
                    DropRegistry();
                break;
                case "print":
                    PrintEmployees();
                break;
                case "p":
                    PrintEmployees();
                break;
                case "quit":
                    Quit();
                break;
                case "q":
                    Quit();
                break;
            }


        } while(running);

    }

    private void WelcomeUser()
    {
        Console.WriteLine();
        Console.WriteLine("Välkommen till personalregistret! Mata in önskat commando(help eller h för hjälp).");
    }

    private void PrintHelp()
    {
        Console.WriteLine();
        Console.WriteLine("Programmet har följande kommandon:");
        Console.WriteLine("Add/a, följt av förnamn efternamn (lön)");
        Console.WriteLine("Remove/rm, följt av förnamn efternamn lön");
        Console.WriteLine("Print/p för att skriva ut listan");
        Console.WriteLine("Drop/d för att tömma listan");
        Console.WriteLine("Quit/q för att avsluta");
    }

    private void PrintEmployees()
    {
        Console.WriteLine();
        Console.WriteLine("Personal: ");
        Console.WriteLine(registry.GetEmployeeDescriptions());
    }

    private void DropRegistry()
    {
        registry.ClearEmployees();
    }

    private void AddEmployee(string[] input)
    {
        if (Employee.TryParse(input, out Employee result))
        {
            registry.AddEmployee(result);
        }
        
    }
    private void RemoveEmployee(string[] input)
    {
        if (Employee.TryParse(input, out Employee result))
        {
            registry.RemoveEmployee(result);
        }
        
    }

    private void Quit()
    {
        running = false;
    }

}