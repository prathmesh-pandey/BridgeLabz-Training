public abstract class Product
{

    // Encapsulation
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }


    // Constructor
    protected Product(int id, string name, double price)
    {
        ProductId = id;
        Name = name;
        Price = price;
    }


    // Abstract method
    public abstract double CalculateDiscount();
}