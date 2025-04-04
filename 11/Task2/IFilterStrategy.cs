namespace Task2;

public interface IFilterStrategy
{
    IEnumerable<int> Filter(IEnumerable<int> data);
}