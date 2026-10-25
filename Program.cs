// Create employee objects
Employee employee = new Employee("Alex", 5000m);
Manager manager = new Manager("Maria", 70000m, 10000m);

// Store objects in a list 
List<Employee> employees = new List<Employee>();

employees.Add(employee);
employees.Add(manager);

// Display payroll information
foreach (Employee person in employees)
{
    person.DisplayInfo();
    Console.WriteLine("---------");
}
