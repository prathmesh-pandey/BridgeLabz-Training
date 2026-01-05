using System;

class Circle
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate area and circumference
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    // Method to display results
    public void Display()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area of Circle: " + CalculateArea());
        Console.WriteLine("Circumference of Circle: " + CalculateCircumference());
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter radius of the circle: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Circle c = new Circle(r);
        c.Display();
    }
}
