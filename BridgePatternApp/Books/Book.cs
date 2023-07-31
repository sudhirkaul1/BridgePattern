using BridgePatternApp.BookContentProvider;
using BridgePatternApp.BookPublishers;

namespace BridgePatternApp.Books;

public class Book : IBook
{
    private IBookContentProvider _bookContentProvider;
    private IBookPublisher _bookPublisher;

    public Book(IBookContentProvider bookContentProvider, IBookPublisher bookPublisher)
    {
        _bookContentProvider = bookContentProvider;
        _bookPublisher = bookPublisher;
    }

    public void Publish()
    {
        IEnumerable<string> bookContent = _bookContentProvider.GetBookContent();
        _bookPublisher.Publish(bookContent);
    }
}