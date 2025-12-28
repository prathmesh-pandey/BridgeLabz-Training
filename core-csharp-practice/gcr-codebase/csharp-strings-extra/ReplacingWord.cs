using System;

class Program
{
    static void Main()
    {
        // Take sentence input from user
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        // Word to be replaced
        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();

        // New word
        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        // Call method
        string result = ReplaceWord(sentence, oldWord, newWord);

        // Display the result
        Console.WriteLine("Modified Sentence: " + result);
    }

    // Method to replace a word manually
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        string result = "";
        int i = 0;

        while (i < sentence.Length)
        {
            bool match = true;

            // Check if old word matches starting at position i
            if (i + oldWord.Length <= sentence.Length)
            {
                for (int j = 0; j < oldWord.Length; j++)
                {
                    if (sentence[i + j] != oldWord[j])
                    {
                        match = false;
                        break;
                    }
                }
            }
            else
            {
                match = false;
            }

            // If word matches, replace it
            if (match)
            {
                result += newWord;
                i += oldWord.Length;
            }
            else
            {
                result += sentence[i];
                i++;
            }
        }

        return result;
    }
}
