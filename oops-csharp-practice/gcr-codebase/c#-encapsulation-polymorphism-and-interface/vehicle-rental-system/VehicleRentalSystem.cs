using System;

class RentalApp
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = ReadCar();
        vehicles[1] = ReadBike();
        vehicles[2] = ReadTruck();

        Console.Write("\nEnter Rental Days: ");
        int days = int.Parse(Console.ReadLine());

        Console.WriteLine("\n--- RENTAL SUMMARY ---");
        ShowSummary(vehicles, days);
    }

    static Vehicle ReadCar()
    {
        Console.WriteLine("Car Details");
        Car car = new Car(ReadRate(), ReadPolicy());
        SetCommon(car, "Car");
        return car;
    }

    static Vehicle ReadBike()
    {
        Console.WriteLine("\nBike Details");
        Bike bike = new Bike(ReadRate(), ReadPolicy());
        SetCommon(bike, "Bike");
        return bike;
    }

    static Vehicle ReadTruck()
    {
        Console.WriteLine("\nTruck Details");
        Truck truck = new Truck(ReadRate(), ReadPolicy());
        SetCommon(truck, "Truck");
        return truck;
    }

    static double ReadRate()
    {
        Console.Write("Rental Rate Per Day: ");
        return double.Parse(Console.ReadLine());
    }

    static string ReadPolicy()
    {
        Console.Write("Insurance Policy Number: ");
        return Console.ReadLine();
    }

    static void SetCommon(Vehicle vehicle, string type)
    {
        Console.Write("Vehicle Number: ");
        vehicle.VehicleNumber = Console.ReadLine();
        vehicle.VehicleType = type;
    }

    static void ShowSummary(Vehicle[] vehicles, int days)
    {
        foreach (Vehicle v in vehicles)
        {
            double rent = v.CalculateRentalCost(days);
            double insurance = 0;

            if (v is IInsurable insurable)
            {
                insurance = insurable.CalculateInsurance();
            }

            Console.WriteLine("Vehicle Number: " + v.VehicleNumber);
            Console.WriteLine("Vehicle Type: " + v.VehicleType);
            Console.WriteLine("Rental Cost: " + rent);
            Console.WriteLine("Insurance Cost: " + insurance);
            Console.WriteLine();
        }
    }
}
