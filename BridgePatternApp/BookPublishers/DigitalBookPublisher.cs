namespace BridgePatternApp.BookPublishers;

public class DigitalBookPublisher : IBookPublisher
{
    public void Publish(IEnumerable<string> bookContent)
    {
         Console.WriteLine($"Successfully printed book to Amazon. (${bookContent.Count()})");
    }
}