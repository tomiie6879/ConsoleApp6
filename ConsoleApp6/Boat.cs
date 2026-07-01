namespace ConsoleApp6;

public class Boat: Vehicle
{
    public override void Move(float speed)
    {
        Console.WriteLine($"Boat is moving  with {speed} km/h");
    }
}