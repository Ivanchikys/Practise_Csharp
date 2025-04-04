namespace Task2;

public class DocumentFileWriter
{
    private const string FileName = "file.data";
    
    public void WriteAndProtect(Document document)
    {
        using (StreamWriter writer = new StreamWriter(FileName))
        {
            writer.WriteLine("Title: " + document.Title);
            writer.WriteLine("Content: " + document.Content);
        }
        
        File.SetAttributes(FileName, FileAttributes.ReadOnly);
    }
}