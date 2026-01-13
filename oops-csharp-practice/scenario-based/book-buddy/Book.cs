public class Book
{
    private string titleAuthor;

    public Book(string title, string author)
    {
        titleAuthor = title + " - " + author;
    }

    public string GetTitle()
    {
        return titleAuthor.Split(" - ")[0];
    }

    public string GetAuthor()
    {
        return titleAuthor.Split(" - ")[1];
    }

    public string GetBookInfo()
    {
        return titleAuthor;
    }
}
