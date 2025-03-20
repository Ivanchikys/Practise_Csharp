using System.Drawing;

Console.Write("Введите размер матрицы N (N < 10): ");
int n = int.Parse(Console.ReadLine());
if (n >= 10 || n <= 0)
{
    Console.WriteLine("Ошибка: N должно быть в диапазоне 1-9");
    return;
}

Console.Write("Введите минимальное значение a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение b: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Ошибка: a должно быть меньше или равно b");
    return;
}

int[,] matrix = new int[n, n];
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i, j] = Random.Shared.Next(a, b + 1);
    }
}

PrintMatrix();
int sum = 0;
foreach (var value in matrix)
{
    if (value < 0) sum += value * value;
}
Console.WriteLine($"\nСумма квадратов отрицательных чисел: {sum}");

Console.WriteLine("\nНаименьшие элементы в каждой строке:");
for (int i = 0; i < n; i++)
{
    int min = matrix[i, 0];
    for (int j = 1; j < n; j++)
    {
        if (matrix[i, j] < min) min = matrix[i, j];
    }
    Console.WriteLine($"[{i+1}] - {min}");
}
void PrintMatrix()
{
    Console.WriteLine("\nИсходная матрица:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
}
