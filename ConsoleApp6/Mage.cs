namespace ConsoleApp6;

public class Mage: Character,IDamageable,IMovable
{
    public override void Attack(string name)
    {
        Console.WriteLine($"{Name} is attacking");
    }

    public void Movable()
    {
        Console.WriteLine($"Mage can move");
    }

    public void TakeDamage(int damage)
    {
        Console.WriteLine($"Mage is taking damage {damage}");
    }
}