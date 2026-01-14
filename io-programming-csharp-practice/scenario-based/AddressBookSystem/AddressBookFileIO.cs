using System;
using System.IO;
using System.Globalization;
using CsvHelper;

namespace AddressBookSystem
{
    public class AddressBookFileIO
    {
        public static void WriteToCsv(IAddressBook book, string path)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                ContactPerson[] persons = book.GetContacts();
                int count = book.GetContactCount();

                for (int i = 0; i < count; i++)
                {
                    csv.WriteRecord(persons[i]);
                    csv.NextRecord();
                }
            }

            Console.WriteLine("Contacts written to CSV.");
        }

        public static void ReadFromCsv(IAddressBook book, string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<ContactPerson>();

                foreach (var person in records)
                {
                    book.AddContact(person);
                }
            }

            Console.WriteLine("Contacts loaded from CSV.");
        }

        public static void WriteToJson(IAddressBook book, string path)
        {
            ContactPerson[] persons = book.GetContacts();
            int count = book.GetContactCount();

            List<ContactPerson> list = new List<ContactPerson>();

            for (int i = 0; i < count; i++)
                list.Add(persons[i]);

            string json = JsonSerializer.Serialize(list, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(path, json);

            Console.WriteLine("Contacts written to JSON.");
        }

        public static void ReadFromJson(IAddressBook book, string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string json = File.ReadAllText(path);

            List<ContactPerson> list =
                JsonSerializer.Deserialize<List<ContactPerson>>(json);

            foreach (var person in list)
                book.AddContact(person);

            Console.WriteLine("Contacts loaded from JSON.");
        }
    }
}