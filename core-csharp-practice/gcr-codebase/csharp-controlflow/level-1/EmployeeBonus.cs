using System;

public class EmployeeBonus{
	static void Main(){
		
		//Taking the salary and years of service of Employees as input from user
		Console.WriteLine("Enter the salary of the employee: ");
		double salary = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the years of service of the employee: ");
		double years = int.Parse(Console.ReadLine());
		

		//Applying logic

		if(years > 5){
			double bonus = 5.0/100 * salary;
			//printing the bonus amount
			Console.WriteLine("The bonus amount is: " + bonus);
		}
        
		else{
			//If someone's years of service is less than five years 
			Console.WriteLine("No Bonus Amount");
		}
	}
}