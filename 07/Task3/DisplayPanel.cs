using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class DisplayPanel
    {
        public void OnWeatherChanged(string condition)
        {
            Console.WriteLine($"Обновление панели: текущая погода - {condition}");
        }
    }
}
