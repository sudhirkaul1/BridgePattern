namespace BridgePatternApp.BookPublishers;

public class PrintBookPublisher : IBookPublisher
{
    public void Publish(IEnumerable<string> bookContent)
    {
       Console.WriteLine($"Successfully printed book. (${bookContent.Count()})");
    }
}