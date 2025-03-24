using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class VolumeControl
    {
        public event EventHandler<int> VolumeChanged;

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Установка громкости: {volume}%");
            VolumeChanged?.Invoke(this, volume);
        }
    }
}
