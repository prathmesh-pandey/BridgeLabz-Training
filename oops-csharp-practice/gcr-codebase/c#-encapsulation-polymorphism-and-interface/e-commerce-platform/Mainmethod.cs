using System;

class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[3];

        products[0] = new Electronics(1, "Laptop", 60000);
        products[1] = new Clothing(2, "Jacket", 3000);
        products[2] = new Groceries(3, "Rice Bag", 1200);

        Console.WriteLine("--- Final Price Details ---");

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"Product: {products[i].Name}");
            Console.WriteLine($"Final Price: {products[i].GetFinalPrice()}");
            Console.WriteLine();
        }
    }
}
