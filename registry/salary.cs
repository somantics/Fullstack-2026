using System.Text;

namespace Fullstack_2026.registry;

public record struct Salary(int Monthly) : IDisplayable
{
    public readonly string GetRecordDisplay()
    {
        var builder = new StringBuilder();
        builder.Append("Mothly salary: ");
        builder.AppendLine(Monthly.ToString());
        return builder.ToString();
    }

    public readonly int GetYearlySalary()
    {
        return Monthly * 12;
    }
}