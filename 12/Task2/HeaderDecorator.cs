namespace Task2;

public class HeaderDecorator : DocumentDecorator
{
    private readonly string _header;

    public HeaderDecorator(IDocument document, string header) 
        : base(document)
    {
        _header = header;
    }

    public override string GetFormattedText()
    {
        return $"=== {_header} ===\n{base.GetFormattedText()}";
    }
}