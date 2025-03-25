using Task2;

DataSerializer dataSerializer = new DataSerializer();

Console.WriteLine("Попытка сериализации сериализуемого объекта:");
dataSerializer.ProcessSerialization(new SerializableClass { Id = 1, Name = "File1" });

Console.WriteLine("\nПопытка сериализации не сериализуемого объекта:");
dataSerializer.ProcessSerialization(new NonSerializableClass { Id = 2, Name = "File2" });
