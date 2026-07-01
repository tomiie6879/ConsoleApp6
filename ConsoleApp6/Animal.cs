namespace ConsoleApp6;

public abstract class Animal
{
    protected string Name;

    public void Eat(string name)
    {
        Console.WriteLine($"{Name} is eating");
    }

    public abstract void Sound();

}