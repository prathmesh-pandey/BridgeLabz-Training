using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookSystem
{
    public class AddressBook : IAddressBook
    {
        private List<ContactPerson> contacts = new List<ContactPerson>();

        // UC2 + UC7
        public void AddContact(ContactPerson person)
        {
            try
            {
                if (contacts.Any(c => c.Equals(person)))
                {
                    Console.WriteLine("Duplicate contact. Cannot add.");
                    return;
                }

                contacts.Add(person);
                Console.WriteLine("Contact added successfully.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while adding contact: " + ex.Message);
            }
        }

        // UC3
        public void EditContact(string firstName)
        {
            try
            {
                var contact = contacts
                    .FirstOrDefault(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

                if (contact == null)
                {
                    Console.WriteLine("Contact not found.");
                    return;
                }

                Console.WriteLine("Editing Contact...");

                Console.Write("Enter Address: ");
                contact.Address = Console.ReadLine();

                Console.Write("Enter City: ");
                contact.City = Console.ReadLine();

                Console.Write("Enter State: ");
                contact.State = Console.ReadLine();

                Console.Write("Enter Zip: ");
                contact.Zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                contact.PhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                contact.Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while editing contact: " + ex.Message);
            }
        }

        // UC4
        public void DeleteContact(string firstName)
        {
            try
            {
                var contact = contacts
                    .FirstOrDefault(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

                if (contact == null)
                {
                    Console.WriteLine("Contact not found.");
                    return;
                }

                contacts.Remove(contact);
                Console.WriteLine("Contact deleted successfully.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting contact: " + ex.Message);
            }
        }

        // UC8 
        public ContactPerson[] GetContacts()
        {
            return contacts.ToArray();
        }

        public int GetContactCount()
        {
            return contacts.Count;
        }
    }
}