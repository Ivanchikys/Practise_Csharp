namespace Task3;

public class CarProcessor
{
    public static List<Car> FilterByYear(List<Car> cars, int minYear)
    {
        return cars.Where(car => car.Year >= minYear).ToList();
    }
}