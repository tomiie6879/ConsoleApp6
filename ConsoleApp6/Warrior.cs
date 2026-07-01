using System.Runtime.CompilerServices;

namespace ConsoleApp6;

public class Warrior: Character
{
    
    public override void Attack(string name)
    {
        Console.WriteLine($"{Name} is attacking");
    }
}