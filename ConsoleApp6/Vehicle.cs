namespace ConsoleApp6;

public abstract class Vehicle
{
    protected string Brand;
    protected float Speed;

    public void Start(string brand)
    {
        Console.WriteLine($"{Brand} Start");
    }
    public void Stop()
    {
        Console.WriteLine($"{Brand} Stop");
    }
    public abstract void Move(float speed);
}