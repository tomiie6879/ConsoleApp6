namespace ConsoleApp6;

public class CreditCard: IPay
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"CreditCard {amount} is successful ");
    }
}