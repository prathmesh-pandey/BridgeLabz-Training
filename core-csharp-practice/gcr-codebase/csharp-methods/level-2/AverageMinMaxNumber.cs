using System;

public class RandomNumberss
{
    static void Main()
    {
        int[] numbers = new int[5];
        Random r = new Random();


        // Generating random 4-digit numbers
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = r.Next(1000, 10000);
            Console.WriteLine(numbers[i]);
        }

        int sum = 0;
        int min = numbers[0];
        int max = numbers[0];


        // Finding sum, min and max
        for (int i = 0; i < 5; i++)
        {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }
        // Printing the result
        Console.WriteLine("Average: " + (sum / 5.0));
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
    }
}
