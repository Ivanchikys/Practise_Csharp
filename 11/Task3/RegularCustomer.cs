namespace Task3;

public class RegularCustomer(string name) : ICustomer
{
    public string Name { get; } = name;

    public void Update(string promotion)
    {
        Console.WriteLine($"[Regular] {Name} получил уведомление: {promotion}");
    }
}