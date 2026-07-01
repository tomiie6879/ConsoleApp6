namespace ConsoleApp6;

public class Car: Vehicle
{
    public override void Move(float speed)
    {
        Console.WriteLine($"Car is moving with {speed} km/h");
    }
}