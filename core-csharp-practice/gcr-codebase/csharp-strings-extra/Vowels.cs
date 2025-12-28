using System;

class Program
{
    static void Main()
    {
        // Take input string from the user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int vowelCount = 0;
        int consonantCount = 0;

        // Convert string to lowercase to simplify comparison
        input = input.ToLower();


        // Loop through each character of the string
        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            // Check if the character is an alphabet
            if (ch >= 'a' && ch <= 'z')
            {
                // Check if the character is a vowel
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowelCount++;
                }
                else
                {
                    // If not vowel its a consonant
                    consonantCount++;
                }
            }
        }

        // Displaying the result
        Console.WriteLine("Number of vowels: " + vowelCount);
        Console.WriteLine("Number of consonants: " + consonantCount);
    }
}
