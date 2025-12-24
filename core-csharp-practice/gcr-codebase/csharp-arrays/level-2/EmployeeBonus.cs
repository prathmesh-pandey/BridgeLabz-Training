using System;

class EmployeeBonusCalculator
{
    static void Main()
    {
        int totalEmployees = 10;

        // Arrays to store salary and years of service
        double[] salary = new double[totalEmployees];
        double[] yearsOfService = new double[totalEmployees];

        // Arrays to store bonus and new salary
        double[] bonus = new double[totalEmployees];
        double[] newSalary = new double[totalEmployees];
        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        // Taking input from user
        for (int i = 0; i < totalEmployees; i++)
        {
            Console.WriteLine("Enter details for Employee " + (i + 1));

            Console.Write("Enter Salary: ");
            salary[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Years of Service: ");
            yearsOfService[i] = Convert.ToDouble(Console.ReadLine());



            if (salary[i] <= 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter again.");
            }
        }

        // Calculating bonus and new salary
        for (int i = 0; i < totalEmployees; i++)
        {
            if (yearsOfService[i] > 5)
            {
                bonus[i] = salary[i] * 0.05;
            }
            else
            {
                bonus[i] = salary[i] * 0.02;
            }

            newSalary[i] = salary[i] + bonus[i];

            // Calculating totals
            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        // Printing final results
        Console.WriteLine("\n--- Zara Company Bonus Summary ---");
        Console.WriteLine("Total Bonus Paid: " + totalBonus);
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}
6