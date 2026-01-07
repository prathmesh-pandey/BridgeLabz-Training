using System;

public abstract class MenuItem
{
    // Encapsulation
    public string Name { get; set; }

    protected double unitPrice;
    protected int count;

    protected MenuItem(double unitPrice, int count)
    {
        this.unitPrice = unitPrice;
        this.count = count;
    }

    // Abstract method
    public abstract double GetTotalCost();

    // Concrete method
    public void ShowDetails()
    {
        Console.WriteLine("Item: " + Name);
        Console.WriteLine("Amount: " + GetTotalCost());
    }
}
