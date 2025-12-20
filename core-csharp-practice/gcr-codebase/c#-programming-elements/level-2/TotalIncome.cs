using System;

public class TotalIncome
{
    public static void Main(string[] args)
    {
        //Taking user input for salary and bonus
        Console.WriteLine("Enter salary: ");
        double Salary=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter bonus: ");
        double Bonus=Convert.ToDouble(Console.ReadLine());

        //calculating total income
        double Income=Salary+Bonus;

        Console.WriteLine("The salary is Rs. " + Salary + " and the bonus is Rs. " + Bonus + ". Hence, the total income is Rs. " + Income + ".");

    }
}
