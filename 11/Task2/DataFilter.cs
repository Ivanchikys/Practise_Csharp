namespace Task2;

public class DataFilter
{
    private IFilterStrategy _strategy;

    public DataFilter(IFilterStrategy strategy)
    {
        SetStrategy(strategy);
    }

    public void SetStrategy(IFilterStrategy strategy)
    {
        _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
    }

    public IEnumerable<int> ApplyFilter(IEnumerable<int> data)
    {
        return _strategy.Filter(data);
    }
}