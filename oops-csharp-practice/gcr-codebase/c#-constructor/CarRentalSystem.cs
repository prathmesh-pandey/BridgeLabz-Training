using System;

class CarRental
{

    // Customer Rental details
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double totalCost;


    // Constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;


        // Calculating cost
        this.totalCost = CalculateCost();
    }



    // Private method
    private double CalculateCost()
    {
        return rentalDays * 1500;
    }


    // Displaying rental info
    public void Display()
    {
        Console.WriteLine($"{customerName} | {carModel} | ₹{totalCost}");
    }

    static void Main()
    {
        CarRental c = new CarRental("Prathmesh", "BMW M4 Competition", 3);
        c.Display();
    }
}
