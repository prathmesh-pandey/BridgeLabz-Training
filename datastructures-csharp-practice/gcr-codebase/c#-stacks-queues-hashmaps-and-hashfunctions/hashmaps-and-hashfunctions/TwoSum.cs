using System;
using System.Collections.Generic;

class TwoSumProblem
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter target sum: ");
        int target = int.Parse(Console.ReadLine());

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int need = target - arr[i];


            // checking if required value already exists
            if (map.ContainsKey(need))
            {
                Console.WriteLine("Indices: " + map[need] + " and " + i);
                return;
            }


            map[arr[i]] = i; // store index
        }

        Console.WriteLine("No valid pair found");
    }
}
