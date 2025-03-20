using System.Diagnostics;

double[] nums = new double[20];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = Math.Round(Random.Shared.NextDouble() * 10 - 5, 2);
}
Console.WriteLine("Исходный массив:");
Console.WriteLine(string.Join(" ; ", nums));

for (int i = 0; i < 10; i++)
{
    double temp1 = nums[i];
    double temp2 = nums[i + 10];
    nums[i] = Math.Max(temp1, temp2);
    nums[i + 10] = Math.Min(temp1, temp2);
}
Console.WriteLine("\nПреобразованный массив:");
Console.WriteLine(string.Join(" ; ", nums));

Array.Sort(nums);
Console.WriteLine("\nОтсортированный массив:");
Console.WriteLine(string.Join(" ; ", nums));

Console.Write("\nВведите число k для бинарного поиска: ");
double k = double.Parse(Console.ReadLine());

int index = Array.BinarySearch(nums, k);
if (index >= 0)
    Console.WriteLine($"Число {k:F2} найдено в массиве на позиции {index}.");
else
    Console.WriteLine($"Число {k:F2} отсутствует в массиве.");
