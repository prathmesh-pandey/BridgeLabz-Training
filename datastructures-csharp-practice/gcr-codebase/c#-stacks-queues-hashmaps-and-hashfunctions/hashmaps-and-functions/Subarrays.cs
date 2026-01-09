using System;
using System.Collections.Generic;

class Subarrays
{

    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());



        // map to store cumulative sum and its indices
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;



        // base case: sum 0 at index -1
        map[0] = new List<int> { -1 };


        for (int i = 0; i < n; i++)
        {

            sum += arr[i];



            // if same sum appears again, zero-sum subarray exists
            if (map.ContainsKey(sum))
            {

                foreach (int start in map[sum])
                    Console.WriteLine($"Subarray found from index {start + 1} to {i}");
            }

            if (!map.ContainsKey(sum))
                map[sum] = new List<int>();

            map[sum].Add(i);
        }
    }
}
