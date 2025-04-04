using Task2;

IDocument document = new PlainDocument("Строка 1\nСтрока 2\nСтрока 3\nСтрока 4\nСтрока 5\nСтрока 6\nСтрока 7");

document = new HeaderDecorator(document, "Заголовок документа");
document = new FooterDecorator(document, "Подвал документа");
document = new PageNumberDecorator(document, 3);

Console.WriteLine(document.GetFormattedText());