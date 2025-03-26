using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Product(int id, string name, decimal price)
    {
        public int Id { get; } = id;
        public string Name { get; } = name; 
        public decimal Price { get; } = price;
        public override string ToString()
        {
            return $"ID: {Id}, Имя: {Name}, Стоимость: {Price:C}";
        }
    }
}
