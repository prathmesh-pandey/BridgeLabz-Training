using System;

class Program
{
    static void Main()
    {
        // Take string input from user
        Console.Write("Enter the main string: ");
        string text = Console.ReadLine();

        // Take substring input
        Console.Write("Enter the substring to search: ");
        string sub = Console.ReadLine();

        int count = 0;

        // Loop through main string
        for (int i = 0; i <= text.Length - sub.Length; i++)
        {
            bool match = true;

            // Check character-by-character match
            for (int j = 0; j < sub.Length; j++)
            {
                if (text[i + j] != sub[j])
                {
                    match = false;
                    break;
                }
            }

            // If full substring matched
            if (match)
            {
                count++;
            }
        }

        // Display the result
        Console.WriteLine("Number of occurrences: " + count);
    }
}
