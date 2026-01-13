using System;

class FirstLastOccurrence
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        Console.Write("Enter target value: ");
        int target = int.Parse(Console.ReadLine()!);

        int first = Find(arr, target, true);
        int last = Find(arr, target, false);

        Console.WriteLine("First occurrence index: " + first);
        Console.WriteLine("Last occurrence index: " + last);
    }


    static int Find(int[] arr, int target, bool first)
    {
        int low = 0, high = arr.Length - 1, result = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                if (first)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return result;
    }
    
}
