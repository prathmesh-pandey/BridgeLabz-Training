using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Employee emp1 = new FullTimeEmployee(101, "Amit", 50000);
        emp1.AssignDepartment("IT");

        Employee emp2 = new PartTimeEmployee(102, "Riya", 120, 300);
        emp2.AssignDepartment("HR");

        employees.Add(emp1);
        employees.Add(emp2);

        // Polymorphism: Employee reference, runtime binding
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
