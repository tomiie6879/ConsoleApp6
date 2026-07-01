namespace ConsoleApp6;

public class Boss : IDamageable
{
    private int HP = 100;
    public void TakeDamage(int damage)
    {
        int currentHP = HP - damage;
        if (currentHP > 0)
        {
            Console.WriteLine($"Boss lost {damage} damage");
        }
        else if (currentHP >= 0)
        {
            Console.WriteLine($"Boss is die");
        }
        
        
    }
}