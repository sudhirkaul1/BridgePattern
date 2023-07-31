namespace BridgePatternApp.BookContentProvider;

public interface IBookContentProvider
{
    IEnumerable<string> GetBookContent();
}
