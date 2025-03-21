using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Product(string name, string category, decimal price, int stockQuantity)
    {
        public  string Name { get; set; } = name;
        public  string Category { get; set; } = category;
        public  decimal Price { get; set; } = price;
        public  int StockQuantity { get; set; } = stockQuantity;
    }
}
