using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DataSerializer
    {
        private readonly Serializer _serializer = new Serializer();

        public void ProcessSerialization(object obj)
        {
            try
            {
                _serializer.Serialize(obj);
                Console.WriteLine("Сериализация прошла успешно.");
            }
            catch (SerializationOperationException ex)
            {
                Console.WriteLine("Произошла ошибка при сериализации: " + ex.Message);
                Console.WriteLine("Внутреннее исключение: " + ex.InnerException?.Message);
                Console.WriteLine("Стек вызовов: " + ex.StackTrace);
            }
        }
    }
}
