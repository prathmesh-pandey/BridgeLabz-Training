using System;
using System.IO;

namespace AddressBookSystem
{
    public class AddressBookFileIO
    {
        public static void WriteToFile(IAddressBook book, string path)
        {
            ContactPerson[] persons = book.GetContacts();
            int count = book.GetContactCount();

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < count; i++)
                {
                    string line =
                        persons[i].FirstName + "," +
                        persons[i].LastName + "," +
                        persons[i].Address + "," +
                        persons[i].City + "," +
                        persons[i].State + "," +
                        persons[i].Zip + "," +
                        persons[i].PhoneNumber + "," +
                        persons[i].Email;

                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Contacts saved to file.");
        }

        public static void ReadFromFile(IAddressBook book, string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                ContactPerson person = new ContactPerson
                {
                    FirstName = data[0],
                    LastName = data[1],
                    Address = data[2],
                    City = data[3],
                    State = data[4],
                    Zip = data[5],
                    PhoneNumber = data[6],
                    Email = data[7]
                };

                book.AddContact(person);
            }

            Console.WriteLine("Contacts loaded from file.");
        }
    }
}
