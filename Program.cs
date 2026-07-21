using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ShopEase Online Shopping System");

        Admin admin = new Admin();

        Product p1 = new Product(
            1001,
            "Laptop",
            "Electronics",
            "Dell Inspiron",
            65000,
            20,
            "Dell",
            10,
            4.6
        );

        Customer c1 = new Customer(
            1,
            "Achal",
            "achal",
            "123",
            "Pune"
        );

        Cart cart = new Cart();

        cart.AddItem(p1, 2);

        Console.WriteLine("\nProducts");
        p1.Display();

        Console.WriteLine("\nCart Total");
        Console.WriteLine(cart.GetTotal());

        Order order = new Order(
            101,
            c1.Name,
            cart.GetTotal()
        );

        Console.WriteLine("\nOrder Details");
        order.Display();

        Payment payment = new Payment("UPI");

        Console.WriteLine("\nPayment Details");
        payment.Display();
    }
}