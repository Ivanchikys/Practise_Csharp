namespace Task2;

public class PlainDocument : IDocument
{
    private readonly string _text;

    public PlainDocument(string text)
    {
        _text = text;
    }

    public string GetFormattedText()
    {
        return _text;
    }
}