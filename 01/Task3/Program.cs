string Calculator(int alpha)
{
    double z1 = (Math.Sin(2*alpha) + Math.Sin(5 * alpha) - Math.Sin(3 * alpha)) /
                Math.Cos(alpha) + 1 - 2 * Math.Pow(Math.Sin(2 * alpha), 2);
    double z2 = 2 * Math.Sin(alpha);
    return $"z1 = {z1}\nz2 = {z2}";
}

Console.Write("Введите альфу: ");
int alpha = int.Parse(Console.ReadLine());
Console.WriteLine(Calculator(alpha));
