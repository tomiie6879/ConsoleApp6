namespace ConsoleApp6;

public abstract class Character
{
    protected string Name;
    protected int HP;

    public void Move(string name)
    {
        Console.WriteLine($"{name} is moving");
    }
    public abstract void Attack(string name);
}