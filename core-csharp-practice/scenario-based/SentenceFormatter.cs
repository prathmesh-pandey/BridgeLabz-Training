using System;
using System.Text;

class Formatter
{
    static string FormatSentence(string input)
    {
        StringBuilder formattedText = new StringBuilder();

        bool shouldCapitalize = true;
        bool canAddSpace = false;
        bool hasStarted = false;

        for (int index = 0; index < input.Length; index++)
        {
            char currentChar = input[index];

            // Skip leading spaces manually
            if (!hasStarted)
            {
                if (currentChar == ' ')
                    continue;

                hasStarted = true;
            }

            if (char.IsLetter(currentChar))
            {
                formattedText.Append(
                    shouldCapitalize ? char.ToUpper(currentChar) : currentChar
                );

                shouldCapitalize = false;
                canAddSpace = true;
            }
            else if (currentChar == '.' || currentChar == '?' || currentChar == '!')
            {
                formattedText.Append(currentChar);
                shouldCapitalize = true;
                canAddSpace = false;
            }
            else if (currentChar == ',')
            {
                formattedText.Append(currentChar);
                canAddSpace = true;
            }
            else if (currentChar == ' ')
            {
                if (canAddSpace)
                {
                    formattedText.Append(' ');
                    canAddSpace = false;
                }
            }
            else
            {
                formattedText.Append(currentChar);
                canAddSpace = true;
            }
        }

        return formattedText.ToString();
    }

    static void Main()
    {
        string input = "   hello   world.this is   a Test!how are   you?i am Fine.   ";
        Console.WriteLine(FormatSentence(input));
    }
}