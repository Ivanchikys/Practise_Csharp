using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Display
    {
        public void OnVolumeChanged(object sender, int volume)
        {
            Console.WriteLine($" -Дисплей: текущий уровень громкости - {volume}%");
        }
    }

}
