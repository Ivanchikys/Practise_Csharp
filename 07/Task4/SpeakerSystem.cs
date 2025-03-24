using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class SpeakerSystem
    {
        public void OnVolumeChanged(object sender, int volume)
        {
            Console.WriteLine($"Аудиосистема: громкость изменена на {volume}%");
        }
    }
}
