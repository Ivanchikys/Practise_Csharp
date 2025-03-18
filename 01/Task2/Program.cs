/*
 12. Дано трёхзначное число. Найти сумму его первой и второй цифр.
*/

using System.Security;
int SumOfDigits(int num)
{
    int sum = 0;
    var firstDigit = num / 100;
    var secondDigit = num / 10 % 10;
    sum = firstDigit + secondDigit;
    return sum;
}
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма двух первых цифр = " + SumOfDigits(num));