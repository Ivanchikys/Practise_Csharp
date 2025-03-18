/*
 12. Дано трёхзначное число. Найти сумму его первой и второй цифр.
*/

using System.Security;
int SumOfDigits(int num)
{
    int sum = 0;
    num = num / 100;
    sum += num;
    num = num % 10;
    sum += num;

    return sum;
}
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма двух первых цифр = " + SumOfDigits(num));