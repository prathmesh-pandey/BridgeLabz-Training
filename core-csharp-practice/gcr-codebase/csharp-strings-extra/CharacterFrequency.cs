using System;

class Program
{
    static void Main()
    {
        // Take input string from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char mostFrequentChar = '\0';
        int maxCount = 0;

        // Loop through each character of the string
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            int count = 0;

            // Count occurrences of current character
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] == currentChar)
                {
                    count++;
                }
            }

            // Update most frequent character
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequentChar = currentChar;
            }
        }

        // Displaying the result
        Console.WriteLine("Most Frequent Character: '" + mostFrequentChar + "'");
    }
}
