using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class ServerConnection
    {
        private const int MaxConnections = 64;

        public void Connect(int activeConnections)
        {
            if (activeConnections > MaxConnections)
            {
                throw new TooManyConnectionsException($"слишком много подключений! Лимит: {MaxConnections}, текущие: {activeConnections}.");
            }
            Console.WriteLine("Подключение успешно установлено.");
        }
    }

}
