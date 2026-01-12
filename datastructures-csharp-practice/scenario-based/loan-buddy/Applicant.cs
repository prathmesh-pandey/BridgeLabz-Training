using System;

class Applicant
{
    public string Name;
    public double Income;
    public double LoanAmount;

    private int CreditScore;
    public Applicant(string name, int CreditScore, double income, double loanAmount)
    {
        Name = name;
        this.CreditScore = CreditScore;
        Income = income;
        LoanAmount = loanAmount;
    }

    //Encapsulation:credit score accessible only internally
    public int GetCreditScore()
    {
        return CreditScore;
    }
}
