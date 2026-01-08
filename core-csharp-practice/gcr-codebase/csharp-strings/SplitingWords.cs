








                                        // LONG CODE NOT PUSHED YET



using System;

class Program
{
    static void Main()
    {
        // Take input from user
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        // Call method to split words and get word-length table
        string[,] result = SplitWordsAndLengths(input);

        // Display result
        Console.WriteLine("\nWord\tLength");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            Console.WriteLine(result[i, 0] + "\t" + result[i, 1]);
        }
    }

    // Method to split text into words WITHOUT using Split()
    static string[,] SplitWordsAndLengths(string text)
    {
        // First count number of words
        int wordCount = 0;
        bool inWord = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ' && !inWord)
            {
                wordCount++;
                inWord = true;
            }
            else if (text[i] == ' ')
            {
                inWord = false;
            }
        }

        // Create 2D array [wordCount x 2]
        string[,] result = new string[wordCount, 2];

        string currentWord = "";
        int index = 0;

        // Extract words manually
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ')
            {
                currentWord += text[i];
            }
            else if (currentWord != "")
            {
                result[index, 0] = currentWord;
                result[index, 1] = GetStringLength(currentWord).ToString();
                index++;
                currentWord = "";
            }
        }

        // Add last word (if any)
        if (currentWord != "")
        {
            result[index, 0] = currentWord;
            result[index, 1] = GetStringLength(currentWord).ToString();
        }

        return result;
    }

    // Method to calculate string length WITHOUT using Length
    static int GetStringLength(string str)
    {
        int length = 0;

        foreach (char c in str)
        {
            length++;
        }

        return length;
    }
}
