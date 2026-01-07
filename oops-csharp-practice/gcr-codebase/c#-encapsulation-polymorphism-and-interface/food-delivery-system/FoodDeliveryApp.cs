using System;

class OrderApp
{
    static void Main()
    {
        FoodItem[] order = CreateOrder();

        Console.WriteLine("\n--- ORDER SUMMARY ---");
        DisplayBill(order);
    }

    static FoodItem[] CreateOrder()
    {
        FoodItem[] items = new FoodItem[2];

        items[0] = ReadVegItem();
        items[1] = ReadNonVegItem();

        return items;
    }

    static FoodItem ReadVegItem()
    {
        Console.WriteLine("Veg Item");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Qty: ");
        int qty = int.Parse(Console.ReadLine());

        VegItem item = new VegItem(price, qty);
        item.ItemName = name;

        return item;
    }

    static FoodItem ReadNonVegItem()
    {
        Console.WriteLine("\nNon-Veg Item");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Qty: ");
        int qty = int.Parse(Console.ReadLine());

        NonVegItem item = new NonVegItem(price, qty);
        item.ItemName = name;

        return item;
    }

    static void DisplayBill(FoodItem[] items)
    {
        foreach (FoodItem item in items)
        {
            double discount = 0;

            if (item is IDiscountable d)
            {
                discount = d.ApplyDiscount();
                Console.WriteLine(d.GetDiscountDetails());
            }

            double payable = item.CalculateTotalPrice() - discount;

            Console.WriteLine("Item: " + item.ItemName);
            Console.WriteLine("Payable: " + payable);
            Console.WriteLine();
        }
    }
}
