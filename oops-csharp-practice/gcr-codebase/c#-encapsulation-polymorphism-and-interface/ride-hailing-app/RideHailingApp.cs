using System;

class RideApp
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = ReadCar();
        vehicles[1] = ReadBike();
        vehicles[2] = ReadAuto();

        Console.Write("\nEnter Travel Distance (Km): ");
        double distance = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- RIDE FARE DETAILS ---");
        ShowFareDetails(vehicles, distance);
    }

    static Vehicle ReadCar()
    {
        Console.WriteLine("Car Details");

        Car car = new Car(ReadRate());
        FillCommonDetails(car);
        UpdateGps(car);

        return car;
    }

    static Vehicle ReadBike()
    {
        Console.WriteLine("\nBike Details");

        Bike bike = new Bike(ReadRate());
        FillCommonDetails(bike);
        UpdateGps(bike);

        return bike;
    }

    static Vehicle ReadAuto()
    {
        Console.WriteLine("\nAuto Details");

        Auto auto = new Auto(ReadRate());
        FillCommonDetails(auto);
        UpdateGps(auto);

        return auto;
    }

    static double ReadRate()
    {
        Console.Write("Rate Per Km: ");
        return double.Parse(Console.ReadLine());
    }

    static void FillCommonDetails(Vehicle vehicle)
    {
        Console.Write("Vehicle Id: ");
        vehicle.VehicleId = int.Parse(Console.ReadLine());

        Console.Write("Driver Name: ");
        vehicle.DriverName = Console.ReadLine();
    }

    static void UpdateGps(Vehicle vehicle)
    {
        if (vehicle is IGPS gps)
        {
            Console.Write("Current Location: ");
            gps.UpdateLocation(Console.ReadLine());
        }
    }

    static void ShowFareDetails(Vehicle[] vehicles, double distance)
    {
        foreach (Vehicle v in vehicles)
        {
            v.GetVehicleDetails();
            Console.WriteLine("Fare: " + v.CalculateFare(distance));

            if (v is IGPS gps)
            {
                Console.WriteLine("Location: " + gps.GetCurrentLocation());
            }

            Console.WriteLine();
        }
    }
}
