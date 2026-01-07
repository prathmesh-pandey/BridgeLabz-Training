public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, double fixedSalary)
        : base(id, name, fixedSalary)
    {
    }

    public override double CalculateSalary()
    {
        return BaseSalary; // Fixed salary
    }
}
