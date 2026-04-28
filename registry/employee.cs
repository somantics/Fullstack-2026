using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Fullstack_2026.registry;

public record struct Employee(Name? Name, Salary? Salary) : IDisplayable
{
    /* Currently, this class models our entries + handles our parsing. 

    This is not ideal, in the future the parsing should be moved to the registry or the CLI. 
    */
    public readonly string GetRecordDisplay()
    {
        var builder = new StringBuilder();
        if (Name.HasValue)
            builder.Append(Name.Value.GetRecordDisplay());
        if (Salary.HasValue)
            builder.Append(Salary.Value.GetRecordDisplay());
        return builder.ToString();
    }

    public readonly Employee GetWithNewName(Name newName)
    {
        return new Employee(newName, this.Salary);
    }


    public readonly Employee GetWithNewSalary(Salary newSalary)
    {
        return new Employee(this.Name, newSalary);
    }

    public static bool TryParse(string[] input, out Employee result)
    {
        result = new Employee();
        if (input is null)
            return false;
        
        Name name;
        // argument format is: first_name last_name salary
        // we ignore everything after that. 
        switch(input.Length)
        {
            case <= 1:
                //log error not enough arguments
                return false;
            case >= 3:
                // we try to construct everything
                name = new Name(input[0], input[1]);
                if (int.TryParse(input[2], out int salaryInt))
                {
                    var salary = new Salary(salaryInt);
                    result = new Employee(name, salary);
                }
                else
                {
                    result = new Employee(name, null);
                }
                return true;
            default:
                // we only construct a name
                name = new Name(input[0], input[1]);
                result = new Employee(name, null);
                return true;

        }
    }
}