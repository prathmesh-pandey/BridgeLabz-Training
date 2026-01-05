using System;

class Book
{
    private string title;
    private string author;
    private double price;

    // constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Title  : " + title);
        Console.WriteLine("Author Name : " + author);
        Console.WriteLine("Book Price  : Rs. " + price);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter author name: ");
        string author = Console.ReadLine();

        Console.Write("Enter book price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        // object creation
        Book book = new Book(title, author, price);
        book.DisplayDetails();
    }
}
