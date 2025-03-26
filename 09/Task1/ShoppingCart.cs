using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ShoppingCart
    {
        private Hashtable products = new Hashtable();
        public void AddProduct(Product product)
        {
            if (!products.ContainsKey(product.Id))
            {
                products.Add(product.Id, product);
                Console.WriteLine($"Продукт {product.Name} добавлен в тележку");
            }
            else
            {
                Console.WriteLine("Товар уже есть в корзине");
            }
        }
        public void RemoveProduct(int productId)
        {
            if (products.ContainsKey(productId))
            {
                products.Remove(productId);
                Console.WriteLine($"\nПродукт с ID {productId} удалён из тележки");
            }
            else
            {
                Console.WriteLine("Продукт не найден в тележке");
            }
        }
        public Product FindProduct(int productId)
        {
            return products.ContainsKey(productId) ? (Product)products[productId] : null;
        }

        public void SortProductsByPrice()
        {
            var sortedProducts = products.Values.Cast<Product>().OrderByDescending(p => p.Price).ToList();
            Console.WriteLine("\n -Продукты отсортированы по цене:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product);
            }
        }
        public void DisplayCart()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("\n -Тележка пуста");
                return;
            }

            Console.WriteLine("\n -Магазинная тележка:");
            foreach (DictionaryEntry entry in products)
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
}
