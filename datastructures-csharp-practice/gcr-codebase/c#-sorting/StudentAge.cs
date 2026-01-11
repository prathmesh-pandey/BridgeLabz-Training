using System;

class CountingSort
{

    static void CountingSort(int[] ages, int min, int max)
    {
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        foreach (int age in ages)
            count[age - min]++;

        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - min] - 1] = ages[i];
            count[ages[i] - min]--;
        }

        Array.Copy(output, ages, ages.Length);
    }


    static void Main()
    {
        int[] ages = { 12, 15, 10, 14, 18, 12 };
        CountingSort(ages, 10, 18);

        Console.WriteLine(string.Join(" ", ages));
    }
}
