using System;

public class VoteChecker
{
    static void Main()
    {

        int[] ages = new int[10];


        // Taking input and checking vote eligibility
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter age of student " + (i + 1));
            ages[i] = Convert.ToInt32(Console.ReadLine());

            if (CanStudentVote(ages[i]))
                Console.WriteLine("Can Vote");
            else
                Console.WriteLine("Cannot Vote");
        }
    }


    // Method to check voting eligibility
    static bool CanStudentVote(int age)
    {
        if (age < 0)
            return false;

        return age >= 18;
    }
}
