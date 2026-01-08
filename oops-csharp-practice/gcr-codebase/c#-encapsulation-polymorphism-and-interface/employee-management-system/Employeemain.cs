using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        Employee[] employees = new Employee[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\n1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            if (choice == 1)
            {
                Console.Write("Enter Fixed Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees[i] = new FullTimeEmployee(id, name, salary);
            }
            else
            {
                Console.Write("Enter Hours Worked: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Enter Hourly Rate: ");
                double rate = double.Parse(Console.ReadLine());

                employees[i] = new PartTimeEmployee(id, name, hours, rate);
            }

            employees[i].AssignDepartment(dept);
        }

        Console.WriteLine("\n--- Employee Details ---");
        for (int i = 0; i < n; i++)
        {
            employees[i].DisplayDetails();
            Console.WriteLine();
        }
    }
}