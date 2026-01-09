using System;

class CircularTour
{
    static void Main()
    {

        Console.Write("Enter number of petrol pumps: ");
        int n = int.Parse(Console.ReadLine());

        int[] petrol = new int[n];
        int[] distance = new int[n];

        Console.WriteLine("Enter petrol at each pump:");
        for (int i = 0; i < n; i++)
            petrol[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter distance to next pump:");
        for (int i = 0; i < n; i++)
            distance[i] = int.Parse(Console.ReadLine());


        int start = 0;
        int surplus = 0;
        int deficit = 0;

        for (int i = 0; i < n; i++)
        {
            surplus += petrol[i] - distance[i];


            // if petrol becomes negative, move start
            if (surplus < 0)
            {
                
                deficit += surplus;
                surplus = 0;
                start = i + 1;

            }
        }


        // check if circular tour is possible
        if (surplus + deficit >= 0)
            Console.WriteLine("Start at petrol pump index: " + start);
        else
            Console.WriteLine("Circular tour not possible");
    }
}
