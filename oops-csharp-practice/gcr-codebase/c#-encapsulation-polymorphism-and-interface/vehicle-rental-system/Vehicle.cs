using System;

public abstract class RentalVehicle
{
    // Encapsulated core details
    public string RegistrationNo { get; set; }
    public string Category { get; set; }

    // Shared rental rate
    protected double dailyCharge;

    protected RentalVehicle(double dailyCharge)
    {
        this.dailyCharge = dailyCharge;
    }

    // Abstract rental logic
    public abstract double ComputeRental(int days);
}
