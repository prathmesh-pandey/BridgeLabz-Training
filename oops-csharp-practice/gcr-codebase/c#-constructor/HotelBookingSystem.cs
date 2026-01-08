using System;

class HotelBooking
{

    //Details of Book
    private string guestName;
    private string roomType;
    private int nights;


    public HotelBooking()
    {
        //Default Constructor
        guestName = "Guest";
        roomType = "Standard";
        nights = 1;
    }
    //Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    //Constructor
    public HotelBooking(HotelBooking other)
    {
        guestName = other.guestName;
        roomType = other.roomType;
        nights = other.nights;
    }


    //Displaying Booking Info
    public void Display()
    {
        Console.WriteLine($"{guestName} | {roomType} | {nights} nights");
    }

    static void Main()
    {
        HotelBooking b1 = new HotelBooking("Aman", "Deluxe", 3);
        HotelBooking b2 = new HotelBooking(b1);

        b2.Display();
    }
}
