using System;

namespace AddressBookSystem
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program\n");

            IAddressBook addressBook = new AddressBook();
            AddressBookMenu menu = new AddressBookMenu(addressBook);
            menu.ShowMenu();
        }
    }
}