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

                Console.WriteLine("0. Exit");
                Console.Write("Choose option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

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

    }
}
