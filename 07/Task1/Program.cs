using Task1;
Speaker speaker = new Speaker();
HeadPhones headphones = new HeadPhones();
VolumeControl volumeControl;
volumeControl = speaker.SetVolume;
volumeControl(50);

volumeControl = headphones.SetVolume;
volumeControl(30);

volumeControl += speaker.SetVolume;
volumeControl(70);

public delegate void VolumeControl(int volume);