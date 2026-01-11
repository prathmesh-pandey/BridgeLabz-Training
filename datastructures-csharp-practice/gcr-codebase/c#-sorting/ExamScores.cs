using System;

class SelectionSort

{
    static void SelectionSort(int[] scores)
    {
        for (int i = 0; i < scores.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < scores.Length; j++)
                if (scores[j] < scores[minIndex])
                    minIndex = j;

            (scores[i], scores[minIndex]) = (scores[minIndex], scores[i]);
        }
    }


    static void Main()
    {
        int[] scores = { 88, 72, 91, 65, 84 };
        SelectionSort(scores);

        Console.WriteLine(string.Join(" ", scores));
    }
}
