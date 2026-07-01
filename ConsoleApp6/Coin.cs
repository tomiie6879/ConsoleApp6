namespace ConsoleApp6;

public class Coin: ICollectable
{
    public void Collectable()
    {
        Console.WriteLine($"Coin has been collected");
    }
}