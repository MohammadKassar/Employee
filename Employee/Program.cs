class Program
{
    class Employee
    {
        public string Name;
        public double Salary;
    }

    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        string addMore;
        do
        {
            Employee newEmployee = new Employee();

            Console.Write("Enter employee name:");
            newEmployee.Name = Console.ReadLine();

            Console.Write("Enter employee salary:");

            if (double.TryParse(Console.ReadLine(), out double salary))
            {
                newEmployee.Salary = salary;
            }
            else
            {
                Console.WriteLine("Invalid salary input Please enter a valid salary.");
                addMore = "y";
                continue;
            }

            employees.Add(newEmployee);

            Console.Write("Do you want to add another employee? (y/n): ");
            addMore = Console.ReadLine().ToLower();
        } while (addMore == "y");


        foreach (var employee in employees)
        {
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
        }
    }
}
// class: 1-Employee. 2-Program (huvudprogram)
// attribut och metoder för varja class: 1-Employee (Attribut "name och salary") 2- Program (Attribut "employees")