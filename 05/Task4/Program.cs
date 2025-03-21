/*Реализуйте расширяющий метод для типа List<string>, который сортирует строки по длине.*/
List<string> words = new List<string> { "melon", "banana", "kiwi", "cherry", "apple" };
words.SortByLength();
Console.WriteLine(string.Join(", ", words));

static class ListExtensions
{
    public static void SortByLength(this List<string> list)
    {
        list.Sort((s1, s2) => s1.Length.CompareTo(s2.Length));
    }
}

