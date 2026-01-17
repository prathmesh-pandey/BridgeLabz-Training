//UC 2
namespace AddressBookSystem{
public interface IAddressBook
{
    void AddContact(ContactPerson person); //UC 2
    void EditContact(string firstName); //UC 3

}
}