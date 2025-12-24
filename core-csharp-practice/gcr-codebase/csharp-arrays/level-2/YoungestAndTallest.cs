using System;

public class YoungestAndTallest
{
    static void Main(string[] args)
    {
        // Array to store names of friends, their ages and thier heights
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Taking input from user for age and height of all friends
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter " + names[i] + " age: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter " + names[i] + " height: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Assuming first person as youngest and tallest initially
        int youngestIndex = 0;
        int tallestIndex = 0;

        // Loop to check for youngest age and tallest height
        for (int i = 1; i < 3; i++)
        {
            // Checking for youngest age
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }

            // Checking for tallest height
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        // Displaying final results
        Console.WriteLine("Youngest friend is: " + names[youngestIndex] + " with age " + ages[youngestIndex]);
        Console.WriteLine("Tallest friend is: " + names[tallestIndex] + " with height " + heights[tallestIndex]);
    }
}
