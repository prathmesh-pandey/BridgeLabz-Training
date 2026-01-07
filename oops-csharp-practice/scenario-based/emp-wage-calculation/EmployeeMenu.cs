using System;

namespace Employee
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeService;

        public void Menu() //UC 4 Used switch case to show menu 
        {
            employeeService = new EmployeeUtilityImpl();

            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Attendance Check (UC1 + UC3)");
                Console.WriteLine("3. Calculate Daily Wage (UC4)");
                Console.WriteLine("4. Calculate Monthly Wage (UC5)");
                Console.WriteLine("5. Calculate Wage Till Condition (UC6)");
                Console.WriteLine("6. Display Employee");
                Console.WriteLine("7. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employeeService.AddEmployee();
                        break;

                    case 2:
                        employeeService.AttendanceCheck();
                        break;

                    case 3:
                        employeeService.CalculateDailyWage();
                        break;

                    case 4:
                        employeeService.CalculateMonthlyWage();
                        break;

                    case 5:
                        employeeService.CalculateWageTillCondition();
                    break;

                    case 6:
                        employeeService.DisplayEmployee();
                        break;

                    case 7:
                        return;
                        default:
                            Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}