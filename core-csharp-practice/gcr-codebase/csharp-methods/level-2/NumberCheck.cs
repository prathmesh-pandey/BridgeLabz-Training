using System;

public class NumberCheck
{
    static void Main()
    {
        int[] numbers = new int[5];

        // Taking user input of numbers
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (numbers[i] >= 0)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine("Positive Even");
                else
                    Console.WriteLine("Positive Odd");
            }
            else
                Console.WriteLine("Negative");
        }

        // Comparing first and last element
        if (numbers[0] > numbers[4])
            Console.WriteLine("First is greater");
        else if (numbers[0] < numbers[4])
            Console.WriteLine("First is smaller");
        else
            Console.WriteLine("Both are equal");
    }
}
