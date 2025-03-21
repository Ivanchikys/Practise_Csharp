using Task4;

RentalCar[] cars = new RentalCar[]
        {
            new RentalCar("Toyota", "Camry", 2020, 50, true),
            new RentalCar("Honda", "Civic", 2019, 40, false),
            new RentalCar("Ford", "Fusion", 2015, 45, true),
            new RentalCar("Toyota", "Corolla", 2018, 35, true)
        };

RentalService service = new RentalService(cars);

Console.WriteLine("Доступные автомобили: ");
foreach (var car in service.GetAvailableCars())
{
    Console.WriteLine($"{car.Brand} {car.Model} ({car.Year}) - {car.PricePerDay:C} в день");
}

Console.WriteLine("\nToyota Автомобили: ");
foreach (var car in service.GetCarsByBrand("Toyota"))
{
    Console.WriteLine($"{car.Brand} {car.Model} ({car.Year}) - {car.PricePerDay:C} в день");
}