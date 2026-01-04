using System;

class Book
{
    // Attributes
    public string Title;
    public string Author;
    public double Price;

    // Default Constructor
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
    }

    // Parameterized Constructor
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    // Method to display book details
    public void DisplayBook()
    {
        Console.WriteLine("Title  : " + Title);
        Console.WriteLine("Author : " + Author);
        Console.WriteLine("Price  : " + Price);
    }
}

class Program
{
    static void Main()
    {
        // Using default constructor
        Book book1 = new Book();
        book1.DisplayBook();

        Console.WriteLine();

        // Using parameterized constructor
        Book book2 = new Book("Clean Code", "Robert C. Martin", 450);
        book2.DisplayBook();
    }
}
