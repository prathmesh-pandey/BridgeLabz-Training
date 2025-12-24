using System;

public class LeapYear
{
    static void Main(string[] args)
    {
        //Taking user input to enter a year
        Console.WriteLine("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());




            //Checking leap year conditions
            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is a Leap Year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine(year + " is not a Leap Year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine(year + " is a Leap Year");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year");
            }

    }
}
