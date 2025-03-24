using Task4;

VolumeControl volumeControl = new VolumeControl();
Display display = new Display();
SpeakerSystem speakerSystem = new SpeakerSystem();

VolumeManager manager = new VolumeManager(volumeControl, display, speakerSystem);
volumeControl.SetVolume(30);
volumeControl.SetVolume(70);