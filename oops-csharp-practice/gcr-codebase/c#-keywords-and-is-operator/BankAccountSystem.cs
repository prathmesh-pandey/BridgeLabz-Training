using System;

class BankAccount
{
    
    // static variable shared across all accounts
    public static string BankName = "State Bank";
    private static int totalAccounts = 0;

    // readonly variable
    public readonly int AccountNumber;

    public string AccountHolderName;
    public double Balance;

    // Constructor using 'this' keyword
    public BankAccount(int AccountNumber, string AccountHolderName, double Balance)
    {
        this.AccountNumber = AccountNumber;               
        this.AccountHolderName = AccountHolderName;       
        this.Balance = Balance;

        totalAccounts++;
    }
    

    public static int GetTotalAccounts()
    {
        return totalAccounts;
    }

    // method to display account details
    public void DisplayDetails()
    {
        Console.WriteLine("Bank Name      : " + BankName);
        Console.WriteLine("Account Number : " + AccountNumber);
        Console.WriteLine("Holder Name    : " + AccountHolderName);
        Console.WriteLine("Balance        : " + Balance);
    }
}


class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount(101, "Rahul", 5000);
        BankAccount acc2 = new BankAccount(102, "Amit", 8000);

        // using 'is' operator
        if (acc1 is BankAccount)
        {
            Console.WriteLine("Account 1 Details:");
            acc1.DisplayDetails();
        }

        Console.WriteLine();

        Console.WriteLine("Total Accounts Created: " + BankAccount.GetTotalAccounts());
    }
}
