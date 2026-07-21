using System;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public double TotalAmount { get; set; }

    public Order(int id, string customerName,
                 double totalAmount)
    {
        OrderId = id;
        CustomerName = customerName;
        TotalAmount = totalAmount;
        OrderDate = DateTime.Now;
    }

    public void Display()
    {
        Console.WriteLine("Order Id : " + OrderId);
        Console.WriteLine("Customer : " + CustomerName);
        Console.WriteLine("Date : " + OrderDate);
        Console.WriteLine("Total : ₹" + TotalAmount);
    }
}