using System;
using System.Collections.Generic;

class LongestSequence
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        HashSet<int> set = new HashSet<int>(arr);
        int longest = 0;

        for (int i = 0; i < n; i++)
        {

            // start counting only if it's the beginning of a sequence
            if (!set.Contains(arr[i] - 1))
            {
                int current = arr[i];
                int count = 1;


                // check consecutive numbers
                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }


        Console.WriteLine("Length of longest consecutive sequence: " + longest);
    }
}
