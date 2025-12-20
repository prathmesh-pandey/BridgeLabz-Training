using System;

public class Dividing_Pens
{
    public static void Main(string[] args)
    {
		//defining number of pens and students
        int Number_Of_Pens = 14;
        int Number_Of_Students = 3;

		//Calculated number of distributed pens
        int Distributed_Pens = Number_Of_Pens/Number_Of_Students;
		//Calculate number of remaining pens
        int Remaining_Pens = Number_Of_Pens%Number_Of_Students;

		//print the result
        Console.WriteLine("The Pen Per Student is " + Distributed_Pens +" and the remaining pen not distributed is " + Remaining_Pens);
    }
}
