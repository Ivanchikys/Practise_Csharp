using Task4;
NetworkAdapter adapter = new NetworkAdapter();
IWiFiConnection wifi = adapter;
wifi.Connect();
IEthernetConnection ethernet = adapter;
ethernet.Connect();