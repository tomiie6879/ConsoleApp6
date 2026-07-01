namespace ConsoleApp6;

public class Player: IDamageable,IInteractable
{
    private int HP = 100;
    public void TakeDamage(int damage)
    {
        int currentHP = HP - damage;
        if (currentHP > 0)
        {
            Console.WriteLine($"Player lost {damage} damage");
        }
        else if (currentHP >= 0)
        {
            Console.WriteLine($"Player is die");
        }
        
        
    }

    public void Interactable()
    {
        Console.WriteLine($"Player has been interacted");
    }
}