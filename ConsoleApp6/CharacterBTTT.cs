namespace ConsoleApp6;

public abstract class CharacterBTTT: IActionable
{
    public string Name { get; set; } 
    public abstract void Damage();
    public abstract void Collect();
    public abstract void Interact();
   
}