using System;

class Program
{
    static void Main()
    {
        // Get current UTC time
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        // Time zones
        TimeZoneInfo gmtZone = TimeZoneInfo.Utc;
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Convert UTC time to different time zones
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmtZone);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);

        // Display the results
        Console.WriteLine("Current Time in Different Time Zones:\n");
        Console.WriteLine("GMT : " + gmtTime);
        Console.WriteLine("IST : " + istTime);
        Console.WriteLine("PST : " + pstTime);
    }
}
