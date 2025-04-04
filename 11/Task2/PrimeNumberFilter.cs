namespace Task2;

public class PrimeNumberFilter : IFilterStrategy
{
    public IEnumerable<int> Filter(IEnumerable<int> data)
    {
        return data.Where(IsPrime);
    }

    private bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}