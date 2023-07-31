namespace BridgePatternApp.BookPublishers;

public class AudioBookPublisher : IBookPublisher
{
    public void Publish(IEnumerable<string> bookContent)
    {
        Console.WriteLine($"Successfully printed book to Audio. ({bookContent.Count()})");
    }
}