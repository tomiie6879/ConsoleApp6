namespace ConsoleApp6;

public class FullTimeEmployee : Employee
{
    public override void CalculateSalary(string name, float salary)
    {
        Console.WriteLine($"{name} salary is {salary}");
    }
}