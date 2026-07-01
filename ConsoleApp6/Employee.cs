namespace ConsoleApp6;

public abstract class Employee
{
    protected string Name;
    protected float Salary;
    public abstract void CalculateSalary(string name, float salary);
}