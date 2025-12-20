using System;

public class Earth_Volume
{
    public static void Main(string[] args)
    {
        //defining radius of earth
        int radius=6378;

        //defining value of pi
        double pi=3.14;

        //calculating volume of earth
        double volume=(4.0/3)*pi*radius*radius*radius;

        //convert volume into cubic miles
        double in_Miles=volume*1.6;

        //print the result
        Console.WriteLine("The volume of earth in cubic kilometers is "+volume+" and cubic miles is "+in_Miles);
    }
	
}