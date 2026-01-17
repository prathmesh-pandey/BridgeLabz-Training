using System;
namespace AddressBookSystem
{
public class AddressBook : IAddressBook
{
    private ContactPerson contact;
//UC2
    public void AddContact(ContactPerson person)
    {
        contact = person;
        Console.WriteLine("Contact added successfully.\n");
    }

    //UC 3
     public void EditContact(string firstName)
    {
        if (contact == null)
        {
            Console.WriteLine("No contact available to edit.");
            return;
        }

        if (contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
        {
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
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}
}