using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TooManyConnectionsException : Exception
    {
        public TooManyConnectionsException(string message) : base(message) { }
    }
}
