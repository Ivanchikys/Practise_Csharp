using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Configurations
    {
        public void SetDatabaseConfig(string config)
        {
            Console.WriteLine($"Настройка базы данных: {config}");
        }

        public void SetCacheConfig(string config)
        {
            Console.WriteLine($"Настройка кеша: {config}");
        }
    }
}
