using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class VolumeManager
    {
        public VolumeManager(VolumeControl volumeControl, Display display, SpeakerSystem speakerSystem)
        {
            volumeControl.VolumeChanged += display.OnVolumeChanged;
            volumeControl.VolumeChanged += speakerSystem.OnVolumeChanged;
        }
    }
}
