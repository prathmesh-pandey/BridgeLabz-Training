//railway registration system oops and dsa principle 
//    sorting and searching
//    passenger interface 
//    senior and normal passenger classes 
//    fair calculation of both types of passengers
//    input of name,pnr and age
//    sort using pnr 
//    search by passenger name 

using RailwayManagement;
    class Program{
    static void Main(string[] args)
    {
        Passenger[] passengers = new Passenger[10];
        IPassenger[] fareList = new IPassenger[10];
        int count = 0;

        Console.WriteLine("Enter number of passengers:");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter Name of the Passenger:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter PNR of the Passenger:");
            int pnr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Age of the Passenger:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 50)
            {
                SeniorPassenger sp = new SeniorPassenger(name, pnr, age);
                passengers[count] = sp;
                fareList[count] = sp;
            }
            else
            {
                NormalPassenger np = new NormalPassenger(name, pnr, age);
                passengers[count] = np;
                fareList[count] = np;
            }

            count++;
        }

        RailwaySystem.SortByPNR(passengers, count);

        Console.WriteLine("\nPassengers Sorted by PNR:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(passengers[i].Getname() + " - " + passengers[i].Getpnr());
        }

        Console.WriteLine("\nEnter name to search:");
        string searchName = Console.ReadLine();

        RailwaySystem.SearchByName(passengers, count, searchName);
        Console.WriteLine("\nFare Details:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(passengers[i].Getname() + " Fare: " + fareList[i].FareCalculation());
        }
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

}