using System;

public class AddressBook : IAddressBook
{
    private ContactPerson contact;
//UC2
    public void AddContact(ContactPerson person)
    {
        contact = person;
        Console.WriteLine("Contact added successfully.\n");
    }
}