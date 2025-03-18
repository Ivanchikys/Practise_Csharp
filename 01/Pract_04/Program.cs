/*
В квадратной комнате шириной A и высотой B есть окно и дверь с размерами
и соответственно. Вычислите площадь стен для оклеивания их обоями.
*/
Console.Write("Введите ширину и длину комнаты (A): ");
double A = double.Parse(Console.ReadLine());

Console.Write("Введите высоту комнаты (B): ");
double B = double.Parse(Console.ReadLine());

Console.Write("Введите ширину окна (W_A): ");
double W_A = double.Parse(Console.ReadLine());

Console.Write("Введите высоту окна (W_B): ");
double W_B = double.Parse(Console.ReadLine());

Console.Write("Введите ширину двери (D_A): ");
double D_A = double.Parse(Console.ReadLine());

Console.Write("Введите высоту двери (D_B): ");
double D_B = double.Parse(Console.ReadLine());

double wallArea = 4 * (A * B);
double windowArea = W_A * W_B;
double doorArea = D_A * D_B;

double wallpaperArea = wallArea - windowArea - doorArea;

Console.WriteLine($"Площадь стен для оклеивания обоями: {wallpaperArea} кв. м");