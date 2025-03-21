/*Создайте метод, который находит индекс элемента в массиве с использованием рекурсии.
Метод должен принимать массив и значение для поиска, возвращать индекс элемента или -1, если элемент не найден.
Пример: FindIndex(new int[] { 5, 3, 9, 1 }, 9) → 2.
    */
static int FindIndex(int[] arr, int value, int index = 0)
{
    if (index >= arr.Length)
        return -1;
    if (arr[index] == value)
        return index;
    return FindIndex(arr, value, index + 1);
}

int[] array = { 5, 3, 9, 1 };
int valueToFind = 9;
int index = FindIndex(array, valueToFind);
Console.WriteLine($"Индекс элемента {valueToFind}: {index}");