namespace Task1;

public class DiscountManager
{
    private static readonly DiscountManager _instance = new DiscountManager();
    private readonly Dictionary<string, double> _discounts;
    
    private DiscountManager()
    {
        _discounts = new Dictionary<string, double>();
    }
    
    public static DiscountManager GetInstance() => _instance;
    
    public void SetDiscount(string product, double percent)
    {
        if (percent < 0 || percent > 100)
            throw new ArgumentOutOfRangeException(nameof(percent), "Скидка должна быть в диапазоне от 0 до 100");

        _discounts[product] = percent;
        Console.WriteLine($"Скидка для продукта \"{product}\" установлена: {percent}%");
    }
    
    public double GetDiscount(string product)
    {
        if (_discounts.TryGetValue(product, out double percent))
            return percent;
        return 0;
    }
}