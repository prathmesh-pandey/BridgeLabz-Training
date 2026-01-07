using System;

public abstract class CatalogItem
{
    // Encapsulation via auto-properties
    public int Id { get; set; }
    public string Title { get; set; }
    public string Creator { get; set; }

    // Abstract rule for loan period
    public abstract int LoanPeriod();

    // Common display logic
    public void ShowDetails()
    {
        Console.WriteLine("Item Id: " + Id);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/Creator: " + Creator);
        Console.WriteLine("Loan Period (Days): " + LoanPeriod());
    }
}
