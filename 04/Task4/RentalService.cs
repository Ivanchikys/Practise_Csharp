using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class RentalService(RentalCar[] rentalCars)
    {
        private RentalCar[] rentalCars = rentalCars;

        public List<RentalCar> GetAvailableCars()
        {
            return rentalCars.Where(car => car.IsAvailable).ToList();
        }

        public List<RentalCar> GetCarsByBrand(string brand)
        {
            return rentalCars.Where(car => car.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
