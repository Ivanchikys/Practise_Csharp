/*Найти в строке слова, встречающиеся только один раз.*/


string str = "doko kiko moko doko piko";
Dictionary<string, int> dict = new Dictionary<string, int>();

var strArr = str.Trim().Split(' ');

foreach (var word in strArr)
{
    if (dict.ContainsKey(word))
        dict[word]++;
    else
        dict[word] = 1;
}

foreach (var word in dict.Where(v => v.Value == 1))
{
    Console.WriteLine($"{word.Key}");
}