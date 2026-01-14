using System;

class CheckingAccount : BankAccount
{
    public double WithdrawalLimit;

    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }
    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Checking Account");
        Console.WriteLine("Withdrawal Limit: " + WithdrawalLimit);
    }
}
