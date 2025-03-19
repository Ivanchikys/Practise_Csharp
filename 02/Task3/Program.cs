using Task3;

Console.Write("Введите целое число > 0: ");
byte n = byte.Parse(Console.ReadLine());
Alternation alternation = new Alternation(n);
alternation.Result();
