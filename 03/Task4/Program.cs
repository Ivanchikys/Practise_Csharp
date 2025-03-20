decimal[,] employees = new decimal[21, 12];
for (int i = 0; i < employees.GetLength(0); i++)
{
    for (int j = 0; j < employees.GetLength(1); j++)
    {
        employees[0,j] = j+1;
        employees[i, j] = (decimal)Math.Round(Random.Shared.NextDouble()*100, 2);
    }
}

for (int i = 0; i < employees.GetLength(0); i++)
{
    for (int j = 0; j < employees.GetLength(1); j++)
    {
        Console.Write($"{employees[i, j],10}");
    }
    Console.WriteLine();
}

Console.WriteLine(GetSumSalaryOfMonth(2) < GetSumSalaryOfMonth(10) ? $"2 < 10 " : " 2 > 10 ");
decimal GetSumSalaryOfMonth(int month)
{
    decimal sum = 0;
    for (int i = 0; i < employees.GetLength(0); i++)
    {
        sum += employees[i, month];
    }
    Console.WriteLine($"Общая сумма зарплаты работников в {month} месяце: {sum}");
    return sum;
}
