using Task1;

ElectronicDeviceFactory laptopFactory = new LaptopFactory();
IElectronicDevice laptop = laptopFactory.CreateDevice();
laptop.TurnOn();

ElectronicDeviceFactory tabletFactory = new TabletFactory();
IElectronicDevice tablet = tabletFactory.CreateDevice();
tablet.TurnOn();

ElectronicDeviceFactory smartphoneFactory = new SmartphoneFactory();
IElectronicDevice smartphone = smartphoneFactory.CreateDevice();
smartphone.TurnOn();