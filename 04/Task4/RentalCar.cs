using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public partial class RentalCar(string brand, string model, int year, decimal pricePerDay, bool isAvailable)
    {
        public string Brand { get; set; } = brand;
        public string Model { get; set; } = model;
        public int Year { get; set; } = year;
        public decimal PricePerDay { get; set; } = pricePerDay;
        public bool IsAvailable { get; set; } = isAvailable;
    }
    public partial class RentalCar
    {
        public void RentCar()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"{Brand} {Model} был арендован");
            }
            else
            {
                Console.WriteLine($"{Brand} {Model} не доступен");
            }
        }

        public void ReturnCar()
        {
            IsAvailable = true;
            Console.WriteLine($"{Brand} {Model} был возвращен и теперь доступен");
        }
    }
}