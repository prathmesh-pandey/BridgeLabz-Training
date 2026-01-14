using System;

class FixedDepositAccount : BankAccount
{
    public int LockInPeriod;

    public FixedDepositAccount(int accountNumber, double balance, int lockInPeriod)
        : base(accountNumber, balance)
    {
        LockInPeriod = lockInPeriod;
    }
    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Fixed Deposit Account");
        Console.WriteLine("Lock-in Period: " + LockInPeriod + " months");
    }
}
