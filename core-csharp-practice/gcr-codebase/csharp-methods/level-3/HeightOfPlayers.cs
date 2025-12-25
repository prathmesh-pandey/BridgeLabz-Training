using System;

public class FootballTeamHeights
{
    static void Main(string[] args)
    {
        // Array to store heights of 11 players
        int[] heights = new int[11];

        Random rand = new Random();


        // Generating random heights between 150-250 cm
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = rand.Next(150, 251);
        }


        // Calling all methods
        int sum = FindSum(heights);
        double mean = FindMean(heights);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        // Displaying results
        Console.WriteLine("\n\nSum of heights: " + sum);
        Console.WriteLine("Mean height: " + mean);
        Console.WriteLine("Shortest height: " + shortest);
        Console.WriteLine("Tallest height: " + tallest);
    }

    // Method to find sum of heights
    static int FindSum(int[] heights)
    {
        int sum = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }
        return sum;
    }

    // Method to find mean height
    static double FindMean(int[] heights)
    {
        int sum = FindSum(heights);
        return sum / (double)heights.Length;
    }

    // Method to find shortest height
    static int FindShortest(int[] heights)
    {
        int min = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] < min)
                min = heights[i];
        }
        return min;
    }

    // Method to find tallest height
    static int FindTallest(int[] heights)
    {
        int max = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > max)
                max = heights[i];
        }
        return max;
    }
}
