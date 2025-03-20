/*Инвертировать порядок символов в StringBuilder.*/
using System.Text;

string str = "Poko loko toki tiko";
StringBuilder builder = new StringBuilder(str.Length);
for (int i = str.Length - 1; i >= 0; i--)
    builder.Append(str[i]);
Console.WriteLine(builder.ToString()); 
