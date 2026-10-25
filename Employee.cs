// Parent Class
public class Employee
{
    // Private salary field 
    private decimal salary;

    // Public employee name
    public string Name { get; set; }

    // Constructor 
    public Employee(string name, decimal salary)
    {
        Name = name;
        this.salary = salary;
    }

    // Get employee salary
    public decimal GetSalary()
    {
        return salary;
    }

    // Calculate yearly pay
    public virtual decimal CalculatePay()
    {
        return salary;
    }

    // Display employee information
    public void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name}");
        Console.WriteLine($"Annual Pay: ${CalculatePay():F2}");
    }
}