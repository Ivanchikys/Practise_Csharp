/*
запрашивает с клавиатуры четыре вещественных числа, и выводит
на экран результат деления первого числа на второе плюс третьего на
четвертое (вещественные числа выводятся с точностью до 2 знаков после
запятой):
*/

Console.WriteLine("-- Введите 4 вещественных числа --");

Console.Write("Первое число: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Второе число: ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("Третье число: ");
double num3 = double.Parse(Console.ReadLine());

Console.Write("Четвертое число: ");
double num4 = double.Parse(Console.ReadLine());

if (num1 is double && num2 is double && num3 is double && num4 is double)
{
    num1 = num1 / num2;
    num2 = num3 / num4;

    Console.WriteLine($"1. num1 / num2 = {Math.Round(num1,2)}" +
        $"\n2. num3 / num4 = {Math.Round(num2, 2)}");
}
else
{
    Console.WriteLine("Введено не вещественное значение числа");
}