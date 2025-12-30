using System;

class TemperatureAnalyzer
{
    static void AnalyzeTemperatures(float[,] temps)
    {
        int days = 7;
        int hours = 24;

        float hottestAvg = float.MinValue;
        float coldestAvg = float.MaxValue;
        int hottestDay = 0;
        int coldestDay = 0;

        for (int day = 0; day < days; day++)
        {
            float sum = 0;

            for (int hour = 0; hour < hours; hour++)
            {
                sum += temps[day, hour];
            }

            float avg = sum / hours;
            Console.WriteLine($"Day {day + 1} Average Temperature: {avg}");

            if (avg > hottestAvg)
            {
                hottestAvg = avg;
                hottestDay = day;
            }

            if (avg < coldestAvg)
            {
                coldestAvg = avg;
                coldestDay = day;
            }
        }

        Console.WriteLine($"\n🔥 Hottest Day: Day {hottestDay + 1} (Avg: {hottestAvg})");
        Console.WriteLine($"❄️ Coldest Day: Day {coldestDay + 1} (Avg: {coldestAvg})");
    }

    static void Main()
    {
        float[,] temperatures = new float[7, 24];

        Console.WriteLine("Enter temperatures for 7 days (24 hours each):");

        for (int day = 0; day < 7; day++)
        {
            Console.WriteLine($"\nDay {day + 1}:");

            for (int hour = 0; hour < 24; hour++)
            {
                Console.Write($"  Hour {hour + 1}: ");
                temperatures[day, hour] = float.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\n--- Temperature Analysis ---");
        AnalyzeTemperatures(temperatures);
    }
}
