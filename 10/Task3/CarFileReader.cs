namespace Task3;

public class CarFileReader
{
    private const string FileName = "file.data";
    
    public List<Car> ReadCars()
    {
        List<Car> cars = new List<Car>();

        if (!File.Exists(FileName))
        {
            Console.WriteLine($"Файл {FileName} не найден.");
            return cars;
        }
        
        string[] lines = File.ReadAllLines(FileName);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;
            
            var parts = line.Split(',');
            if (parts.Length < 2)
                continue;

            string brandPart = parts[0].Trim();
            string yearPart = parts[1].Trim();
            
            if (int.TryParse(yearPart, out int year))
            {
                cars.Add(new Car(brandPart, year));
            }
        }
        return cars;
    }
}