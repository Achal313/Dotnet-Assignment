class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; }
    public double Discount { get; set; }
    public double Rating { get; set; }

    public Product(int id, string name, string category,
        string description, double price, int quantity,
        string brand, double discount, double rating)
    {
        ProductId = id;
        Name = name;
        Category = category;
        Description = description;
        Price = price;
        Quantity = quantity;
        Brand = brand;
        Discount = discount;
        Rating = rating;
    }

    public void Display()
    {
        System.Console.WriteLine(
        $"{ProductId} {Name} {Category} ₹{Price} Stock:{Quantity}");
    }
}