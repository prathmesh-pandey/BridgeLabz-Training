using System;

class ElectricVehicle : Vehicle
{
    public ElectricVehicle(int maxSpeed, string model)
        : base(maxSpeed, model)
    {
    }
        public void Charge()
    {
        Console.WriteLine(Model + " is charging");
    }
}
