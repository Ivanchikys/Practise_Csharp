Console.Write("Введите радиус: ");
double radius = double.Parse(Console.ReadLine());
Console.Write("Площадь круга по формуле 'S = п * r^2' : ");
Console.Write($"{AreaCircle(radius):F3}");
static double AreaCircle(double radius)
{
    double S = Math.PI * Math.Pow(radius,2);
    return S;
}
