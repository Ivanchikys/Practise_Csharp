/*Удалить все цифры из строки.*/
using System.Text.RegularExpressions;

string input = "go4124od56bye6341e";
string result = Regex.Replace(input, @"\d", "").Trim(); 
Console.WriteLine(result);