// Manager inherits from Employee
public class Manager : Employee
{
    // Manager bonus 
    public decimal Bonus { get; set; }

    // Constructor 
    public Manager(string name, decimal salary, decimal bonus)
        : base(name, salary)
    {
        Bonus = bonus;
    }

    // Override salary calculation
    public override decimal CalculatePay()
    {
        return GetSalary() + Bonus;
    }
}