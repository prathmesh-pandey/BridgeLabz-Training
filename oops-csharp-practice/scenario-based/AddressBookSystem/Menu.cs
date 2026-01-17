using System;

namespace AddressBookSystem
{
    public class AddressBookMenu
    {
        private IAddressBook addressBook;

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

            addressBook.AddContact(person);
        }

        //UC 3
        private void EditContactFlow()
        {
            Console.Write("Enter First Name to edit: ");
            string name = Console.ReadLine();

            addressBook.EditContact(name);
        }
    }
}
