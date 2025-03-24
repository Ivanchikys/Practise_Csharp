using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class WeatherStation
    {
        public event WeatherChangedHandler WeatherChanged;

        public void UpdateWeather(string condition)
        {
            Console.WriteLine($"Погода изменилась: {condition}");
            WeatherChanged?.Invoke(condition);
        }
    }
}
