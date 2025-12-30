using System;

class LibrarySystem
{
    static string[] titles = new string[10];
    static string[] authors = new string[10];
    static bool[] isAvailable = new bool[10];
    static int bookCount = 3;

    static int booksBorrowed = 0;

    static void Initialize()
    {
        titles[0] = "The Alchemist";
        authors[0] = "Paulo Coelho";
        isAvailable[0] = true;

        titles[1] = "Clean Code";
        authors[1] = "Robert Martin";
        isAvailable[1] = true;

        titles[2] = "Atomic Habits";
        authors[2] = "James Clear";
        isAvailable[2] = true;
    }

    // -------- ROLE MENU --------
    static void RoleMenu()
    {
        while (true)
        {
            Console.WriteLine("\n=== Login Menu ===");
            Console.WriteLine("1. User");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    UserMenu();
                    break;

                case 2:
                    AdminMenu();
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // -------- USER MENU --------
    static void UserMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- User Menu ---");
            Console.WriteLine("1. Search Book");
            Console.WriteLine("2. Checkout Book");
            Console.WriteLine("3. Return Book");
            Console.WriteLine("4. View Borrow Count");
            Console.WriteLine("5. Back");
            Console.Write("Option: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    SearchBook();
                    break;

                case 2:
                    CheckoutBook();
                    break;

                case 3:
                    ReturnBook();
                    break;

                case 4:
                    Console.WriteLine("Books borrowed: " + booksBorrowed);
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    // -------- ADMIN MENU --------
    static void AdminMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Admin Menu ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Delete Book");
            Console.WriteLine("3. View All Books");
            Console.WriteLine("4. View User Status");
            Console.WriteLine("5. Back");
            Console.Write("Option: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddBook();
                    break;

                case 2:
                    DeleteBook();
                    break;

                case 3:
                    DisplayBooks();
                    break;

                case 4:
                    Console.WriteLine("User borrowed: " + booksBorrowed);
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    // -------- CORE METHODS --------
    static void DisplayBooks()
    {
        for (int i = 0; i < bookCount; i++)
        {
            Console.WriteLine(
                (i + 1) + ". " + titles[i] +
                " | " + authors[i] +
                " | " + (isAvailable[i] ? "Available" : "Checked Out")
            );
        }
    }

    static void SearchBook()
    {
        Console.Write("Enter title keyword: ");
        string key = Console.ReadLine().ToLower();

        bool found = false;
        for (int i = 0; i < bookCount; i++)
        {
            if (titles[i].ToLower().Contains(key))
            {
                Console.WriteLine(titles[i] + " | " + authors[i]);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No book found.");
    }

    static void CheckoutBook()
    {
        DisplayBooks();
        Console.Write("Book number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < bookCount && isAvailable[index])
        {
            isAvailable[index] = false;
            booksBorrowed++;
            Console.WriteLine("Book checked out.");
        }
        else
        {
            Console.WriteLine("Unavailable book.");
        }
    }

    static void ReturnBook()
    {
        DisplayBooks();
        Console.Write("Book number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < bookCount && !isAvailable[index])
        {
            isAvailable[index] = true;
            booksBorrowed--;
            Console.WriteLine("Book returned.");
        }
        else
        {
            Console.WriteLine("Invalid return.");
        }
    }

    static void AddBook()
    {
        Console.Write("Title: ");
        titles[bookCount] = Console.ReadLine();

        Console.Write("Author: ");
        authors[bookCount] = Console.ReadLine();

        isAvailable[bookCount] = true;
        bookCount++;

        Console.WriteLine("Book added.");
    }

    static void DeleteBook()
    {
        DisplayBooks();
        Console.Write("Book number to delete: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        for (int i = index; i < bookCount - 1; i++)
        {
            titles[i] = titles[i + 1];
            authors[i] = authors[i + 1];
            isAvailable[i] = isAvailable[i + 1];
        }

        bookCount--;
        Console.WriteLine("Book deleted.");
    }

    static void Main()
    {
        Initialize();
        RoleMenu();
    }
}
