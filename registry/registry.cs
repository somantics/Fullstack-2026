using System.Text;

namespace Fullstack_2026.registry;

internal class Registry
{
    /* Internal representation of the personell registry. 

    Uses a list internally now, but should work the same for the user if we swap to a database. 
    Note that we are using immutable data: it is this class' responsibility to hide this from the user.
    */
    private List<Employee> registry = [];

    public void AddEmployee(Employee employee)
    {
        registry.Add(employee);
    }

    public void RemoveEmployee(Employee employee)
    {
        registry.Remove(employee);
    }

    public void UpdateSalary(Employee employee, Salary newSalary)
    {
        if (registry.Contains(employee))
        {
            RemoveEmployee(employee);
            AddEmployee(employee.GetWithNewSalary(newSalary));
        }
        else
        {
            // log error to client
        }
    }

    public void UpdateName(Employee employee, Name newName)
    {
        if (registry.Contains(employee))
        {
            RemoveEmployee(employee);
            AddEmployee(employee.GetWithNewName(newName));
        }
        else
        {
            // log error to client
        }
    }

    public void AddEmployees(IEnumerable<Employee> employees)
    {
        registry.AddRange(employees);
    }

    public void ClearEmployees()
    {
        registry.Clear();
    }

    public string GetEmployeeDescriptions()
    {
        var builder = new StringBuilder();
        foreach (var employee in registry)
        {
            builder.AppendLine(employee.GetRecordDisplay());
        }

        return builder.ToString();
    }
}