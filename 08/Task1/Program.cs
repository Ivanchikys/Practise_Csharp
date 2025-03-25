using Task1;

try
{
    List<int> grades = new List<int> { 85, 90, 78, 102 };
    double average = StudentGrade.CalculateAverage(grades);
    Console.WriteLine($"Средний балл: {average}");
}
catch (InvalidGradeException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}