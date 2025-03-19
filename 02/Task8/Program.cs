using Task8;

Console.Write("Введите A (1 <= A <= 10): ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите B (1 <= B <= 10 и A < B): ");
int B = int.Parse(Console.ReadLine());

ProductCalculator calculator = new ProductCalculator(A, B);
int result = calculator.CalculateProduct();
Console.WriteLine($"Произведение чисел от {A} до {B}: {result}");