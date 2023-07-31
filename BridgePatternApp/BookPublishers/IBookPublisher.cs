namespace BridgePatternApp.BookPublishers;

public interface IBookPublisher
{
    void Publish(IEnumerable<string> bookContent);
}