using System;

class Program
{
    static void Main()
    {
        // Taking string input from user
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int minLength = str1.Length < str2.Length ? str1.Length : str2.Length;
        bool differenceFound = false;

        // Compare character by character
        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                Console.WriteLine("First string comes BEFORE second string.");
                differenceFound = true;
                break;
            }
            else if (str1[i] > str2[i])
            {
                Console.WriteLine("First string comes AFTER second string.");
                differenceFound = true;
                break;
            }
        }

        // If all compared characters are equal
        if (!differenceFound)
        {
            if (str1.Length == str2.Length)
            {
                Console.WriteLine("Both strings are EQUAL.");
            }
            else if (str1.Length < str2.Length)
            {
                Console.WriteLine("First string comes BEFORE second string.");
            }
            else
            {
                Console.WriteLine("First string comes AFTER second string.");
            }
        }
    }
}
