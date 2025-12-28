using System;

class Program
{
    static void Main()
    {
        
        // Take string input from user
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        // Convert both strings to lowercase
        str1 = str1.ToLower();
        str2 = str2.ToLower();

        // If lengths are different, they cannot be anagrams
        if (str1.Length != str2.Length)
        {
            Console.WriteLine("The strings are NOT anagrams.");
            return;
        }


        bool isAnagram = true;


        // Check frequency of each character
        for (int i = 0; i < str1.Length; i++)
        {
            char ch = str1[i];
            int count1 = 0;
            int count2 = 0;

            // Count character in first string
            for (int j = 0; j < str1.Length; j++)
            {
                if (str1[j] == ch)
                    count1++;
            }

            // Count character in second string
            for (int j = 0; j < str2.Length; j++)
            {
                if (str2[j] == ch)
                    count2++;
            }

            // If counts differ, not an anagram
            if (count1 != count2)
            {
                isAnagram = false;
                break;
            }
        }

        // Display result
        if (isAnagram)
        {
            Console.WriteLine("The strings ARE anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are NOT anagrams.");
        }
    }
}
