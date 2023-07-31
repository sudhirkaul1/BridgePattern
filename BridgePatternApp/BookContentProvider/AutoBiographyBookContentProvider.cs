namespace BridgePatternApp.BookContentProvider;
public class AutoBiographyBookContentProvider : IBookContentProvider
{
    public IEnumerable<string> GetBookContent()
    {
       return new List<string>
        {
            "I was born",
            "I learned prog",
            "I became youtuber"
        };
    }
}