using System;

namespace AddressBookSystem
{
    public class AddressBook
    {
        private ContactPerson contact;

        // UC1: Add Contact
        public void AddContact(ContactPerson person)
        {
            contact = person;
            Console.WriteLine("Contact added successfully.\n");
        }
    }
}
