using System;

public class TelephoneDirectory
{
    static string[] names;
    static string[] phoneNumbers;
    static string[] cities;
    static string[] genders;
    static int count;

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the telephone directory:");
        int sizee = Convert.ToInt32(Console.ReadLine());
        names = new string[sizee];
        phoneNumbers = new string[sizee];
        cities = new string[sizee];
        genders = new string[sizee];
        count = 0;

        while (true)
        {
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2.Delete Entry");
            Console.WriteLine("3. Display Entries");
            Console.WriteLine("4. Search Entries");
            Console.WriteLine("5. Update");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option to continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddEntry();
                    break;
                case 2:
                    DeleteEntry();
                    break;
                case 3:
                    DisplayEntry();
                    break;
                case 4:
                    SearchEntry();
                    break;
                case 5:
                    UpdateEntry();
                    break;
                case 6:
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
        static void AddEntry()
        {
            Console.WriteLine("Enter phone number:");
            string phone = Console.ReadLine();

            if (phone.Length != 10)
            {
                Console.WriteLine("Phone number must be exactly 10 digits");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                if (phoneNumbers[i] == phone)
                {
                    Console.WriteLine("Phone number already exists");
                    return;
                }
            }

            Console.WriteLine("Enter name:");
            names[count] = Console.ReadLine();

            phoneNumbers[count] = phone;

            Console.WriteLine("Enter city:");
            cities[count] = Console.ReadLine();

            Console.WriteLine("Enter gender:");
            genders[count] = Console.ReadLine();

            count++;
            Console.WriteLine("Contact added");
        }

        static void DeleteEntry()
        {
            Console.WriteLine("Enter phone number to delete:");
            string phone = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (phoneNumbers[i] == phone)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        names[j] = names[j + 1];
                        phoneNumbers[j] = phoneNumbers[j + 1];
                        cities[j] = cities[j + 1];
                        genders[j] = genders[j + 1];
                    }
                    count--;
                    Console.WriteLine("Contact deleted");
                    return;
                }
            }

        }

        static void DisplayEntry()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(names[i] + phoneNumbers[i] + cities[i] + genders[i]);
            }
        }
        static void SearchEntry()
        {
            Console.WriteLine("Enter keywords for searching:");
            string keyword = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (names[i].Contains(keyword) ||
                    phoneNumbers[i].Contains(keyword) ||
                    cities[i].Contains(keyword))
                {
                    Display(i);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No matching contacts found");
            }
        }

    }
}