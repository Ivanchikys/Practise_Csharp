namespace Task2;

public abstract class DocumentDecorator : IDocument
{
    protected readonly IDocument _document;

    protected DocumentDecorator(IDocument document)
    {
        _document = document;
    }

    public virtual string GetFormattedText()
    {
        return _document.GetFormattedText();
    }
}