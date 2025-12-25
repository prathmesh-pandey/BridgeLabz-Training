using System;

public class YoungestAndTalllest
{
    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] age = new int[3];
        double[] height = new double[3];


        // Taking user input for age and height
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter age of " + names[i]);
            age[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height of " + names[i]);
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        FindYoungest(age, names);
        FindTallest(height, names);

    }


    // Method to find youngest friend
    static void FindYoungest(int[] age, string[] names)
    {
        int minIndex = 0;
        for (int i = 1; i < age.Length; i++)
            if (age[i] < age[minIndex])
                minIndex = i;

        Console.WriteLine("Youngest is: " + names[minIndex]);
    }


    // Method to find tallest friend
    static void FindTallest(double[] height, string[] names)
    {
        int maxIndex = 0;
        for (int i = 1; i < height.Length; i++)
            if (height[i] > height[maxIndex])
                maxIndex = i;

        Console.WriteLine("Tallest is: " + names[maxIndex]);
    }
}
