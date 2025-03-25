using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task2
{
    public class Serializer
    {
        public void Serialize(object obj)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(obj);
                File.WriteAllText("serialized_data.json", jsonString);
            }
            catch (Exception ex)
            {
                throw new SerializationOperationException("Ошибка при сериализации объекта.", ex);
            }
        }
    }
}
