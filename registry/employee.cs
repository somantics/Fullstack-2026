using System.Text;

namespace Fullstack_2026.registry;

public record struct Employee(Name? Name, Salary? Salary) : IDisplayable
{
    public readonly string GetRecordDisplay()
    {
        var builder = new StringBuilder();
        if (Name.HasValue)
            builder.Append(Name.Value.GetRecordDisplay());
        if (Salary.HasValue)
            builder.AppendLine(Salary.Value.GetRecordDisplay());
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
}