using System;
using System.Collections.Generic;

// Book class (can exist independently)
class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void DisplayBook()
    {
        Console.WriteLine("Title  : " + Title);
        Console.WriteLine("Author : " + Author);
    }
}

// Library class (aggregates Book objects)
class Library
{
    public string LibraryName;
    private List<Book> books;

    public Library(string libraryName)
    {
        LibraryName = libraryName;
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void DisplayLibraryBooks()
    {
        Console.WriteLine("Library: " + LibraryName);
        Console.WriteLine("Books Available:");

        foreach (Book book in books)
        {
            Console.WriteLine("----------------");
            book.DisplayBook();
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating Book objects (independent)
        Book b1 = new Book("Clean Code", "Robert C. Martin");
        Book b2 = new Book("The Pragmatic Programmer", "Andrew Hunt");

        // Creating Library objects
        Library lib1 = new Library("City Library");
        Library lib2 = new Library("College Library");

        // Aggregation: adding books to libraries
        lib1.AddBook(b1);
        lib1.AddBook(b2);

        lib2.AddBook(b1); // same book in another library

        Console.WriteLine();
        lib1.DisplayLibraryBooks();

        Console.WriteLine();
        lib2.DisplayLibraryBooks();
    }
}
