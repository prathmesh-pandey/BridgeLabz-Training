using System;
namespace AddressBookSystem
{
public class AddressBook : IAddressBook
{
private ContactPerson[] contacts = new ContactPerson[100];
private int contactCount = 0;

//UC2

//UC 5
    public void AddContact(ContactPerson person)
{
    if (contactCount >= contacts.Length)
    {
        Console.WriteLine("Address Book is full.");
        return;
    }

    contacts[contactCount] = person;
    contactCount++;

    Console.WriteLine("Contact added successfully.\n");
}


    //UC 3

    //UC 5
     public void EditContact(string firstName)
{
    for (int i = 0; i < contactCount; i++)
    {
        if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Editing Contact...");

            Console.Write("Enter Address: ");
            contacts[i].Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contacts[i].City = Console.ReadLine();

            Console.Write("Enter State: ");
            contacts[i].State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            contacts[i].Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contacts[i].PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            contacts[i].Email = Console.ReadLine();

            Console.WriteLine("Contact updated successfully.\n");
            return;
        }
    }

    Console.WriteLine("Contact not found.");
}

    //UC 4
    
    //UC 5
   public void DeleteContact(string firstName)
{
    for (int i = 0; i < contactCount; i++)
    {
        if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
        {
            for (int j = i; j < contactCount - 1; j++)
            {
                contacts[j] = contacts[j + 1];
            }

            contacts[contactCount - 1] = null;
            contactCount--;

            Console.WriteLine("Contact deleted successfully.\n");
            return;
        }
    }

    Console.WriteLine("Contact not found.");
}

}
}