/*Описать процедуру SortDec3(A, B, C), меняющую содержимое переменных A, B, C таким образом,
 *      чтобы их значения оказались упорядоченными по убыванию (A, B, C — вещественные параметры, являющиеся одновременно входными и выходными). 
 * С помощью этой процедуры упорядочить по убыванию два данных набора из трех чисел: (A1, B1, C1) и (A2, B2, C2).
*/
double A1 = 5.2, B1 = 7.1, C1 = 3.8;
double A2 = 9.3, B2 = 2.4, C2 = 6.7;
SortDec3(ref A1, ref B1, ref C1);
Console.WriteLine($"Отсортированный первый набор: {A1}, {B1}, {C1}");
SortDec3(ref A2, ref B2, ref C2);
Console.WriteLine($"Отсортированный второй набор: {A2}, {B2}, {C2}");
static void SortDec3(ref double A, ref double B, ref double C)
{
    if (A < B) Swap(ref A, ref B);
    if (A < C) Swap(ref A, ref C);
    if (B < C) Swap(ref B, ref C);
}
static void Swap(ref double x, ref double y)
{
    double temp = x;
    x = y;
    y = temp;
}