/*
 Дано четырехзначное число. Найти число, образуемое при
перестановке второй и третьей цифр заданного числа.

1234 
1 = 1000
2 = 100
3 = 10
4 = % 10
*/

Console.Write("Введите четырехзначное число: ");
int num = int.Parse(Console.ReadLine());

var firstDigit = num / 1000;
var secondDigit = num / 100 % 10;
var thirdDigit = num % 100 / 10;
var fourthDigit = num % 10;

var neNum = firstDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + fourthDigit;
Console.WriteLine(neNum);
