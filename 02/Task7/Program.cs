using Task7;

Console.Write("Введите A (начало диапазона): ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите B (конец диапазона, B >= A): ");
int B = int.Parse(Console.ReadLine());

Console.Write("Введите X (последняя цифра): ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите Y (последняя цифра): ");
int Y = int.Parse(Console.ReadLine());

EvenNumbersFinder finder = new EvenNumbersFinder(A, B, X, Y);
finder.PrintUsingWhile();
finder.PrintUsingDoWhile();
finder.PrintUsingFor();