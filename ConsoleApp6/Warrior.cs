using System.Runtime.CompilerServices;

namespace ConsoleApp6;

public class Warrior: Character,IDamageable,IMovable
{
    
    public override void Attack(string name)
    {
        Console.WriteLine($"{name} is attacking");
    }

    public void Movable()
    {
        Console.WriteLine("Warrior can move");
    }

    
   

    public void TakeDamage(int damage)
    {
        Console.WriteLine($"{damage} damage is hit");
    }
}