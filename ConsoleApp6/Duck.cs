namespace ConsoleApp6;

public class Duck: Animal,IFly,ISwim
{
    public override void Sound()
    {
        Console.WriteLine("Quac Quac");
    }

    public void Fly()
    {
        Console.WriteLine("Duck can Flying");
    }

    public void Swim()
    {
        Console.WriteLine("Duck can Swim");
    }
}