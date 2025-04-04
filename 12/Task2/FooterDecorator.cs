namespace Task2;

public class FooterDecorator : DocumentDecorator
{
    private readonly string _footer;

    public FooterDecorator(IDocument document, string footer)
        : base(document)
    {
        _footer = footer;
    }

    public override string GetFormattedText()
    {
        return $"{base.GetFormattedText()}\n--- {_footer} ---";
    }
}