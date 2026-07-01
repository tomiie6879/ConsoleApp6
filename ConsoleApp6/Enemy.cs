namespace ConsoleApp6;

public class Enemy: IDamageable
{
    private int HP = 100;
    public void TakeDamage(int damage)
    {
        int currentHP = HP - damage;
        if (currentHP > 0)
        {
            Console.WriteLine($"Enemy lost {damage} damage");
        }
        else if (currentHP >= 0)
        {
            Console.WriteLine($"Enemy is die");
        }
        
        
    }
}