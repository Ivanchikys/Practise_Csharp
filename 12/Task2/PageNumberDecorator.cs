namespace Task2;

public class PageNumberDecorator : DocumentDecorator
{
    private readonly int _linesPerPage;

    public PageNumberDecorator(IDocument document, int linesPerPage = 5)
        : base(document)
    {
        _linesPerPage = linesPerPage;
    }

    public override string GetFormattedText()
    {
        var text = base.GetFormattedText();
        var lines = text.Split('\n').ToList();
        var pages = new List<string>();
        int pageNumber = 1;

        for (int i = 0; i < lines.Count; i += _linesPerPage)
        {
            var pageLines = lines
                .Skip(i)
                .Take(_linesPerPage)
                .ToList();

            pageLines.Add($"--- (Страница {pageNumber}) ---");
            pages.Add(string.Join("\n", pageLines));
            pageNumber++;
        }

        return string.Join("\n\n", pages);
    }
}

