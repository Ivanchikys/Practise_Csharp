using Task2;

Document doc = new Document("Секретный документ", "Содержимое документа");
DocumentFileWriter writer = new DocumentFileWriter();
writer.WriteAndProtect(doc);
Console.WriteLine("Документ записан");