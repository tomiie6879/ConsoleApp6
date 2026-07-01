namespace ConsoleApp6;

public class PlayerBTTT: CharacterBTTT
{
    public override void Damage()
    {
        Console.WriteLine("Player attacks!");
    } 
    public override void Collect()
    {
        
        Console.WriteLine("Player collects item.");
    }

    public override void Interact()
    {
        Console.WriteLine("Player interacts with object.");
    }
    
}