namespace Task3;

public class PromotionManager
{
    private readonly List<ICustomer> _loyalCustomers;
    private readonly List<ICustomer> _regularCustomers;

    public PromotionManager()
    {
        _loyalCustomers = new List<ICustomer>();
        _regularCustomers = new List<ICustomer>();
    }
    
    public void Subscribe(ICustomer customer)
    {
        if (customer is LoyalCustomer)
            _loyalCustomers.Add(customer);
        else
            _regularCustomers.Add(customer);
    }
    
    public void Unsubscribe(ICustomer customer)
    {
        if (customer is LoyalCustomer)
            _loyalCustomers.Remove(customer);
        else
            _regularCustomers.Remove(customer);
    }
    
    public void AddPromotion(string promotion)
    {
        Console.WriteLine($"Новая акция: {promotion}");
        NotifyCustomers(promotion);
    }

    private void NotifyCustomers(string promotion)
    {
        foreach (var customer in _loyalCustomers)
        {
            customer.Update(promotion);
        }
        foreach (var customer in _regularCustomers)
        {
            customer.Update(promotion);
        }
    }
}