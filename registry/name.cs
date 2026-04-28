using System.Text;

namespace Fullstack_2026.registry;

public record struct Name(string FirstName, string LastName) : IDisplayable
{
    public readonly string GetRecordDisplay()
    {
        var builder = new StringBuilder();
        builder.Append(FirstName);
        builder.Append(" ");
        builder.AppendLine(LastName);
        return builder.ToString();
    }
}