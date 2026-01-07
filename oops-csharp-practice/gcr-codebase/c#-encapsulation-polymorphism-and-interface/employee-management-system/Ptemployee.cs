public class PartTimeEmployee : Employee
{
    private int hoursWorked;
    private double hourlyRate;

    public PartTimeEmployee(int id, string name, int hoursWorked, double hourlyRate)
        : base(id, name, 0)
    {
        this.hoursWorked = hoursWorked;
        this.hourlyRate = hourlyRate;
    }

    public override double CalculateSalary()
    {
        return hoursWorked * hourlyRate;
    }
}
