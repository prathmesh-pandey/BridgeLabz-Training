using System;

class Employee
{
	public string Name;
	public int Id;
	public double Salary;

	public Employee(string name, int id, double salary)
	{
		Name = name;
		Id = id;
		Salary = salary;
	}

	public void DisplayDetails()
	{
		Console.WriteLine("Employee Name   : " + Name);
		Console.WriteLine("Employee ID     : " + Id);
		Console.WriteLine("Employee Salary : " + Salary);
	}
}

class Program
{
	static void Main()
	{
		// Creating object of Employee
		Employee emp = new Employee("Rahul", 101, 45000);


		// Display employee details
		emp.DisplayDetails();
	}
}