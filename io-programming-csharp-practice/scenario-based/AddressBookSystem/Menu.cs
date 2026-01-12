using System;

namespace AddressBookSystem
{
    public class AddressBookMenu
    {
        private IAddressBook addressBook;
        // UC6
        private string[] bookNames = new string[10];
        private IAddressBook[] books = new IAddressBook[10];
        private int bookCount = 0;

        private IAddressBook currentBook = null;


        public AddressBookMenu(IAddressBook addressBook)
        {
            this.addressBook = addressBook;
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n ADDRESS BOOK MENU ");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Create Address Book");
                Console.WriteLine("5. Select Address Book");
                Console.WriteLine("6. Search by City/State");
                Console.WriteLine("7. View Persons by City/State");
                Console.WriteLine("8. Count by City/State");
                Console.WriteLine("9. Sort Contacts");
                Console.WriteLine("11. Save as CSV (Library)");
                Console.WriteLine("12. Load from CSV (Library)");
                Console.WriteLine("0. Exit");
                Console.Write("Choose option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }


                switch (choice)
                {
                    case 1:
                        AddContactFlow();
                        break;
                    case 2:
                        EditContactFlow();
                        break;
                    case 3:
                        DeleteContactFlow();
                        break;
                    case 4:
                        CreateAddressBook();
                        break;
                    case 5:
                        SelectAddressBook();
                        break;
                    case 6:
                        SearchPersonFlow();
                        break;
                    case 7:
                        ViewByCityOrStateFlow();
                        break;
                    case 8:
                        CountByCityOrStateFlow();
                        break;
                    case 9:
                        SortContactsFlow();
                        break;
                    case 10:
                        SortByCityStateZipFlow();
                        break;
                    case 11:
                        AddressBookFileIO.WriteToCsv(currentBook, "contacts.csv");
                        break;
                    case 12:
                        AddressBookFileIO.ReadFromCsv(currentBook, "contacts.csv");
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        //UC 2
        private void AddContactFlow()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            ContactPerson person = new ContactPerson();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            person.City = Console.ReadLine();

            Console.Write("Enter State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            person.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();

            currentBook.AddContact(person);
        }

        //UC 3
        private void EditContactFlow()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            Console.Write("Enter First Name to edit: ");
            string name = Console.ReadLine();

            currentBook.EditContact(name);
        }
        //UC 4
        private void DeleteContactFlow()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }
            Console.Write("Enter First Name to delete: ");
            string name = Console.ReadLine();
            currentBook.DeleteContact(name);
        }

        //UC 6
        private void CreateAddressBook()
        {
            Console.Write("Enter new Address Book name: ");
            string name = Console.ReadLine();

            // check duplicate
            for (int i = 0; i < bookCount; i++)
            {
                if (bookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Address Book already exists.");
                    return;
                }
            }

            if (bookCount >= books.Length)
            {
                Console.WriteLine("Cannot create more Address Books.");
                return;
            }

            bookNames[bookCount] = name;
            books[bookCount] = new AddressBook();
            bookCount++;

            Console.WriteLine("Address Book created.");
        }
        private void SelectAddressBook()
        {
            Console.Write("Enter Address Book name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < bookCount; i++)
            {
                if (bookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    currentBook = books[i];
                    Console.WriteLine($"Selected: {name}");
                    return;
                }
            }

            Console.WriteLine("Address Book not found.");
        }

        //UC 8
        private void SearchPersonFlow()
        {
            Console.Write("Enter City or State: ");
            string input = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < bookCount; i++)
            {
                ContactPerson[] persons = books[i].GetContacts();
                int count = books[i].GetContactCount();

                for (int j = 0; j < count; j++)
                {
                    if (persons[j].City.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                        persons[j].State.Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(
                            $"Found in Book: {bookNames[i]} → {persons[j].FirstName} {persons[j].LastName}");

                        found = true;
                    }
                }
            }

            if (!found)
                Console.WriteLine("No matching contacts found.");
        }

        //UC 9
        private void ViewByCityOrStateFlow()
        {
            Console.Write("View by (city/state): ");
            string type = Console.ReadLine();

            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < bookCount; i++)
            {
                ContactPerson[] persons = books[i].GetContacts();
                int count = books[i].GetContactCount();

                for (int j = 0; j < count; j++)
                {
                    bool match = false;

                    if (type.Equals("city", StringComparison.OrdinalIgnoreCase))
                        match = persons[j].City.Equals(value, StringComparison.OrdinalIgnoreCase);

                    else if (type.Equals("state", StringComparison.OrdinalIgnoreCase))
                        match = persons[j].State.Equals(value, StringComparison.OrdinalIgnoreCase);

                    if (match)
                    {
                        Console.WriteLine($"Book: {bookNames[i]} → {persons[j].FirstName} {persons[j].LastName}");
                        found = true;
                    }
                }
            }

            if (!found)
                Console.WriteLine("No records found.");
        }

        //UC 10
        private void CountByCityOrStateFlow()
        {
            Console.Write("Count by (city/state): ");
            string type = Console.ReadLine();

            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            int total = 0;

            for (int i = 0; i < bookCount; i++)
            {
                ContactPerson[] persons = books[i].GetContacts();
                int count = books[i].GetContactCount();

                for (int j = 0; j < count; j++)
                {
                    if (type.Equals("city", StringComparison.OrdinalIgnoreCase) &&
                        persons[j].City.Equals(value, StringComparison.OrdinalIgnoreCase))
                        total++;

                    else if (type.Equals("state", StringComparison.OrdinalIgnoreCase) &&
                             persons[j].State.Equals(value, StringComparison.OrdinalIgnoreCase))
                        total++;
                }
            }

            Console.WriteLine($"Total persons found: {total}");
        }
        // UC11
        private void SortContactsFlow()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            ContactPerson[] persons = currentBook.GetContacts();
            int count = currentBook.GetContactCount();

            Console.WriteLine("Sort by:");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. City");
            Console.WriteLine("3. State");
            Console.WriteLine("4. Zip");

            int choice = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    bool swap = false;

                    switch (choice)
                    {
                        case 1:
                            swap = string.Compare(persons[j].FirstName, persons[j + 1].FirstName, true) > 0;
                            break;
                        case 2:
                            swap = string.Compare(persons[j].City, persons[j + 1].City, true) > 0;
                            break;
                        case 3:
                            swap = string.Compare(persons[j].State, persons[j + 1].State, true) > 0;
                            break;
                        case 4:
                            swap = string.Compare(persons[j].Zip, persons[j + 1].Zip, true) > 0;
                            break;
                    }

                    if (swap)
                    {
                        ContactPerson temp = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted Contacts:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{persons[i].FirstName} {persons[i].LastName} - {persons[i].City}");
            }
        }
        // UC12
        private void SortByCityStateZipFlow()
        {
            if (currentBook == null)
            {
                Console.WriteLine("Please select an Address Book first.");
                return;
            }

            ContactPerson[] persons = currentBook.GetContacts();
            int count = currentBook.GetContactCount();

            Console.WriteLine("Sort by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            Console.WriteLine("3. Zip");

            int choice = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    bool swap = false;

                    switch (choice)
                    {
                        case 1:
                            swap = string.Compare(persons[j].City, persons[j + 1].City, true) > 0;
                            break;
                        case 2:
                            swap = string.Compare(persons[j].State, persons[j + 1].State, true) > 0;
                            break;
                        case 3:
                            swap = string.Compare(persons[j].Zip, persons[j + 1].Zip, true) > 0;
                            break;
                    }

                    if (swap)
                    {
                        ContactPerson temp = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted Results:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{persons[i].FirstName} {persons[i].LastName} - {persons[i].City}");
            }
        }
    }
}
