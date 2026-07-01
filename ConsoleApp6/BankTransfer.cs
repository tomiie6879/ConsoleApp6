namespace ConsoleApp6;

public class BankTransfer: IPay
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Banktransfer {amount} is successful ");
    }
}