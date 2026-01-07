using System;

public abstract class TransportUnit
{
    // Encapsulated details
    public int Id { get; set; }
    public string OperatorName { get; set; }

    // Shared rate for fare calculation
    protected double perKmCost;

    protected TransportUnit(double perKmCost)
    {
        this.perKmCost = perKmCost;
    }

    // Abstract rule
    public abstract double ComputeFare(double distance);

    // Common display
    public void ShowInfo()
    {
        Console.WriteLine("Vehicle Id: " + Id);
        Console.WriteLine("Driver Name: " + OperatorName);
    }
}
