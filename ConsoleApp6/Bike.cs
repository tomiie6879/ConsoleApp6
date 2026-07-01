namespace ConsoleApp6;

public class Bike : Vehicle

{
    public override void Move(float speed)
    {
        Console.WriteLine($"Bike is moving  with {speed} km/h");
    }
}