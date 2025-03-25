using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SerializationOperationException : Exception
    {
        public SerializationOperationException(string message, Exception innerException)
            : base(message, innerException) { }
    }

}
