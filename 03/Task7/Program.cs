string str = "  duck go to home";
string[] words = str.Trim().Split(' ');
for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length > 0)
    {
        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
    }
}
Console.WriteLine(string.Join(' ', words));