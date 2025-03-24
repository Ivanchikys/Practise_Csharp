using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class WarningSystem
    {
        public void OnWeatherChanged(string condition)
        {
            if (condition.ToLower().Contains("шторм"))
            {
                Console.WriteLine("ВНИМАНИЕ! Штормовое предупреждение!");
            }
        }
    }
}
