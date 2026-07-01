namespace ConsoleApp6;

public class Healer: Character,IMovable,IHealable
{
    public void Movable()
    {
        
        Console.WriteLine($"you can move");
    }

    public void Healable()
    {
        Console.WriteLine($"you have been healed");
    }

    public override void Attack(string name)
    {
        Console.WriteLine($"{name} is attacking");
    }

  
}