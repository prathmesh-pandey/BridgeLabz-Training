using System;

namespace Employee
{
    internal class Employee
    {
        private string employeeid;
        private string employeename;
        private string employeesalary;
        private string employeeattendance;   
        private int dailywage;   //UC2 Daily wage Calculation
        private string employeetype;   // UC3 Employee Type
        private int monthlywage;   // UC5 Monthly Wage
        private int totalworkinghours;   // UC6

        public string EmployeeId
        {
            get
            {
                return employeeid;
            }
            set
            {
                employeeid = value;
            }
        }


        public string EmployeeName
        {
            get
            {
                return employeename;
            }
            set
            {
                employeename = value;
            }
        }


        public string EmployeeSalary
        {
            get
            {
                return employeesalary;
            }
            set
            {
                employeesalary = value;
            }
        }


        public string EmployeeAttendance
        {
            get
            {
                return employeeattendance;
            }
            set
            {
                employeeattendance = value;
            }
        }

        // UC2 Daily Wage
        public int DailyWage
        {
            get { return dailywage; }
            set { dailywage = value; }
        }

        //UC 3
        public string EmployeeType
{
    get
    {
        return employeetype;
    }
    set
    {
        employeetype = value;
    }
}       
    //UC 5
    public int MonthlyWage
{
    get
    {
        return monthlywage;
    }
    set
    {
        monthlywage = value;
    }
}

//UC 6
public int TotalWorkingHours
{
    get
    {
        return totalworkinghours;
    }
    set
    {
        totalworkinghours = value;
    }
}
        public override string ToString()
        {
            return "Employee ID : " + employeeid + "\nEmployee Name : " + employeename + "\nEmployee Salary : " + employeesalary + "\nEmployee Attendance : " + employeeattendance + "\nDaily Wage : " + dailywage+ "\nMonthly Wage : " + monthlywage+"\nTotal Working Hours : " + totalworkinghours;
        }
    
    }
}
