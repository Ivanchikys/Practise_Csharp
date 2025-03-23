using Task3;

Medicine[] medicines =
{
    new Antibiotic("Амоксициллин"),
    new CoughSyrup("Сироп от кашля Бронхолитин"),
    new Antibiotic("Азитромицин"),
    new CoughSyrup("Сироп Гербион")
};
Console.WriteLine("\nЛекарства:");
foreach (var medicine in medicines)
{
    Console.WriteLine($" -{medicine.Name}");
}
var syrups = medicines.OfType<ILiquidMedicine>();
Console.WriteLine("\nНайденные сиропы:");
foreach (var syrup in syrups)
{
    Console.WriteLine($" -{(syrup as Medicine)?.Name}");
}