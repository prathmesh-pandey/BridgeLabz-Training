using System;

class FirstNegative
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];

        // Taking array input
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        // Linear search for first negative number
        foreach (int num in arr)
        {
            if (num < 0)
            {
                Console.WriteLine("First Negative: " + num);
                return;
            }
        }

        Console.WriteLine("No negative number found");
    }
}
