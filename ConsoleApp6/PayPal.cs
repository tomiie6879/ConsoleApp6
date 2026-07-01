namespace ConsoleApp6;

public class PayPal: IPay
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"PayPal {amount} is successful ");
    }
}