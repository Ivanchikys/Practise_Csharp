namespace Task3;

public class LoyalCustomer(string name): ICustomer
{
    public string Name { get; } = name;

    public void Update(string promotion)
    {
        Console.WriteLine($"[Loyal] {Name} получил уведомление: {promotion}");
    }
}
