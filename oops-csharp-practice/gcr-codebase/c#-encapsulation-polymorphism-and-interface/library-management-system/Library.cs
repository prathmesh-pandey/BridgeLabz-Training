using System;

class LibraryApp
{
    static void Main()
    {
        LibraryItem[] items = new LibraryItem[3];

        items[0] = ReadBook();
        items[1] = ReadMagazine();
        items[2] = ReadDVD();

        Console.WriteLine("\n--- LIBRARY INVENTORY ---");
        DisplayItems(items);
    }

    static LibraryItem ReadBook()
    {
        Console.WriteLine("Book Details");

        Book b = new Book();
        FillCommonDetails(b);
        return b;
    }

    static LibraryItem ReadMagazine()
    {
        Console.WriteLine("\nMagazine Details");

        Magazine m = new Magazine();
        FillCommonDetails(m);
        return m;
    }

    static LibraryItem ReadDVD()
    {
        Console.WriteLine("\nDVD Details");

        DVD d = new DVD();
        FillCommonDetails(d);
        return d;
    }

    static void FillCommonDetails(LibraryItem item)
    {
        Console.Write("Item Id: ");
        item.ItemId = int.Parse(Console.ReadLine());

        Console.Write("Title: ");
        item.Title = Console.ReadLine();

        Console.Write("Author: ");
        item.Author = Console.ReadLine();
    }

    static void DisplayItems(LibraryItem[] items)
    {
        foreach (LibraryItem item in items)
        {
            item.GetItemDetails();

            if (item is IReservable reservable)
            {
                Console.WriteLine("Available: " + reservable.CheckAvailability());

                Console.Write("Reserve this item? (yes/no): ");
                string choice = Console.ReadLine();

                if (choice == "yes")
                {
                    reservable.ReserveItem();
                    Console.WriteLine("Reservation successful");
                }
            }

            Console.WriteLine();
        }
    }
}
