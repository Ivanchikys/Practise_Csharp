using Task2;

var numbers = Enumerable.Range(1, 20).ToList();

var filter = new DataFilter(new EvenNumberFilter());
Console.WriteLine("Четные числа: " + string.Join(", ", filter.ApplyFilter(numbers)));

filter.SetStrategy(new PrimeNumberFilter());
Console.WriteLine("Простые числа: " + string.Join(", ", filter.ApplyFilter(numbers)));

filter.SetStrategy(new RangeFilter(10, 15));
Console.WriteLine("Числа в диапазоне 10-15: " + string.Join(", ", filter.ApplyFilter(numbers)));