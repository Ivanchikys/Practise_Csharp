/*
12. пересчета расстояния из верст в километры (1 верста равняется 1066,8м).

Пересчет расстояния из верст в километры.
Введите расстояние в верстах и нажмите &lt;Enter&gt;. -&gt; 100
100 верст(а/ы) - это 106.68 км.
*/

using System.Transactions;
string VerstOfKm(double verst)
{
    double verstMeter = 1066.8;
    double km = verst * verstMeter;
    km = km / 1000;
    return $"\n  'Перевод верст -> км'  \nМетры в вёрстах = {verstMeter}м\nКм = 1000м\n - Киллометры из вёрст = {km}км";
}

Console.Write("Введите расстояние в верстах (1 верста = 1066,8м): ");
double verst = double.Parse(Console.ReadLine());
Console.Write("Нажмите 'Enter' чтобы продолжить");

if (Console.ReadKey(true).Key == ConsoleKey.Enter)
{
    Console.WriteLine(VerstOfKm(verst));
}
else
{
    Console.WriteLine("Неверная клавиша. Попробуйте снова");
}



