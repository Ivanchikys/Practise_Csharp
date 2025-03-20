Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите минимальную длину строки: ");
int minLength = int.Parse(Console.ReadLine());

Console.Write("Введите максимальную длину строки: ");
int maxLength = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элемента: ");
int minValue = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента: ");
int maxValue = int.Parse(Console.ReadLine());

if (rows <= 0 || minLength <= 0 || maxLength < minLength)
{
    Console.WriteLine("Ошибка: некорректные входные данные.");
    return;
}

int[][] jaggedArray = GenerateJaggedArray(rows, minLength, maxLength, minValue, maxValue);
PrintArray(jaggedArray);

if (!HasDuplicateRows(jaggedArray))
{
    Console.WriteLine("\nОдинаковых строк не найдено.");
}
static int[][] GenerateJaggedArray(int rows, int minLength, int maxLength, int minValue, int maxValue)
{
   
    int[][] jaggedArray = new int[rows][];

    for (int i = 0; i < rows; i++)
    {
        int length = Random.Shared.Next(minLength, maxLength + 1);
        jaggedArray[i] = new int[length];

        for (int j = 0; j < length; j++)
        {
            jaggedArray[i][j] = Random.Shared.Next(minValue, maxValue + 1);
        }
    }
    return jaggedArray;
}

static void PrintArray(int[][] jaggedArray)
{
    Console.WriteLine("\nСтупенчатый массив:");
    foreach (var row in jaggedArray)
    {
        Console.WriteLine(string.Join(" ", row));
    }
}

static bool HasDuplicateRows(int[][] jaggedArray)
{
    for (int i = 0; i < jaggedArray.Length - 1; i++)
    {
        for (int j = i + 1; j < jaggedArray.Length; j++)
        {
            if (AreRowsEqual(jaggedArray[i], jaggedArray[j]))
            {
                Console.WriteLine($"\nОбнаружены одинаковые строки: {i + 1} и {j + 1}");
                return true;
            }
        }
    }
    return false;
}

static bool AreRowsEqual(int[] row1, int[] row2)
{
    if (row1.Length != row2.Length) return false;

    for (int i = 0; i < row1.Length; i++)
    {
        if (row1[i] != row2[i])
            return false;
    }
    return true;
}
