using System;

class Program
{
    static void Main()
    {
        // Taking sentence input from user
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string currentWord = "";
        string longestWord = "";

        // Loop through each character of the sentence
        for (int i = 0; i < sentence.Length; i++)
        
        {

            if (sentence[i] != ' ')
            {
                // Build the current word character by character
                currentWord += sentence[i];
            }
            else
            {

                // When space is found, compare word lengths
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = ""; // Reset for next word
            }
        }


        // Check the last word
        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }
        // Display the result
        Console.WriteLine("Longest word: " + longestWord);
    }
}
