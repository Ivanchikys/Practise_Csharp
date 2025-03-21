using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class OnlineStore
    {
        private Product[] products;

        public OnlineStore(Product[] products)
        {
            this.products = products;
        }

        public List<Product> GetOutOfStockProducts()
        {
            return products.Where(p => p.StockQuantity == 0).ToList();
        }

        public Product GetMostExpensiveProduct()
        {
            return products.OrderByDescending(p => p.Price).FirstOrDefault();
        }
    }
}
