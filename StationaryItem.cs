using System;

public class StationeryItem
{
    private int quantity;
    private double price;

    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public string Category { get; set; }
    public string Brand { get; set; }

    public double Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
                throw new InvalidPriceException();

            price = value;
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value <= 0)
                throw new InvalidQuantityException();

            quantity = value;
        }
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Item Id: " + ItemId);
        Console.WriteLine("Item Name: " + ItemName);
        Console.WriteLine("Category: " + Category);
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Quantity);
    }

    public void UpdateQuantity(int qty)
    {
        Quantity = qty;
    }
}