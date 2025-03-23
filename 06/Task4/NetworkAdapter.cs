using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class NetworkAdapter : IWiFiConnection, IEthernetConnection
    {
        void IWiFiConnection.Connect()
        {
            Console.WriteLine("Подключение через WiFi выполнено.");
        }

        void IEthernetConnection.Connect()
        {
            Console.WriteLine("Подключение через Ethernet выполнено.");
        }
    }
}
