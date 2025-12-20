using System;

public class Discounted_Fee_Second
{
    public static void Main(string[] args)
    {
        //Taking user input for fee and discount
		Console.WriteLine("Enter the fee: ");
        double Fee=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the Discount Percent: ");
        double Discount_Percent=Convert.ToDouble(Console.ReadLine());

        //Calculating discounted fee
        double Discounted_Amount=(Fee*Discount_Percent)/100.0;
        double FeeToPay=Fee-Discounted_Amount;

        //Printing the result
        Console.WriteLine("The discounted amount is "+Discounted_Amount+" and final discounted fee is "+FeeToPay);
    }
}
