using Task3;

CarFileReader reader = new CarFileReader();
List<Car> cars = reader.ReadCars();

Console.WriteLine("Все автомобили из файла:");
foreach (Car car in cars)
{
    Console.WriteLine($"{car.Brand} {car.Year}");
}

List<Car> filteredCars = CarProcessor.FilterByYear(cars, 2015);

Console.WriteLine($"\nАвтомобили, выпущенные с 2015 года и новее:");
foreach (Car car in filteredCars)
{
    Console.WriteLine($"{car.Brand} {car.Year}");
}