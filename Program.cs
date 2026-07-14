class Program
{
    static void Main()
    {
        
        Customer customer = new Customer();

        Console.WriteLine("Customer Registration");

        Console.Write("Enter Customer ID: ");
        customer.CustomerId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        customer.Name = Console.ReadLine();

        Console.Write("Enter Email: ");
        customer.Email = Console.ReadLine();

        Console.Write("Enter Password: ");
        customer.Password = Console.ReadLine();

        Console.WriteLine("Registration Successful");

        
        int attempts = 0;
        bool loginSuccess = false;

        while (attempts < 3)
        {
            Console.WriteLine("\nLogin");

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (email == customer.Email && password == customer.Password)
            {
                Console.WriteLine("Welcome " + customer.Name);
                loginSuccess = true;
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Invalid Credentials");
            }
        }

        if (!loginSuccess)
        {
            Console.WriteLine("Account Locked");
            return;
        }

        
        List<Product> products = new List<Product>();

        Console.Write("\nHow many products do you want to add? ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Product p = new Product();

            Console.Write("Enter Product ID: ");
            p.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            p.ProductName = Console.ReadLine();

            Console.Write("Enter Price: ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Stock: ");
            p.Stock = Convert.ToInt32(Console.ReadLine());

            products.Add(p);
        }

        
        Console.WriteLine("\nAll Products");

        foreach (Product p in products)
        {
            Console.WriteLine("Product Id : " + p.ProductId);
            Console.WriteLine("Product Name : " + p.ProductName);
            Console.WriteLine("Price : " + p.Price);
            Console.WriteLine("Stock : " + p.Stock);
            Console.WriteLine();
        }

        
        Console.Write("Enter product name to search: ");
        string searchName = Console.ReadLine();

        bool found = false;

        foreach (Product p in products)
        {
            if (p.ProductName == searchName)
            {
                Console.WriteLine("\nProduct Found");
                Console.WriteLine("Product Id : " + p.ProductId);
                Console.WriteLine("Product Name : " + p.ProductName);
                Console.WriteLine("Price : " + p.Price);
                Console.WriteLine("Stock : " + p.Stock);

                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Product Not Found");
        }

        List<CartItem> cart = new List<CartItem>();

        int choice;

        do
        {
            Console.Write("\nEnter Product ID: ");
            int pid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            bool productFound = false;

            foreach (Product p in products)
            {
                if (p.ProductId == pid)
                {
                    productFound = true;

                    if (qty <= p.Stock)
                    {
                        CartItem c = new CartItem();

                        c.ProductId = p.ProductId;
                        c.ProductName = p.ProductName;
                        c.Quantity = qty;
                        c.Amount = p.Price * qty;

                        cart.Add(c);

                        p.Stock = p.Stock - qty;

                        Console.WriteLine("Product Added To Cart");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Stock");
                    }
                }
            }

            if (!productFound)
            {
                Console.WriteLine("Invalid Product ID");
            }

            Console.WriteLine("\nDo you want to add another product?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            choice = Convert.ToInt32(Console.ReadLine());

        } while (choice == 1);

        Console.WriteLine("\nCart");

        double totalAmount = 0;

        foreach (CartItem c in cart)
        {
            Console.WriteLine(c.ProductName + " x" + c.Quantity);
            totalAmount += c.Amount;
        }

        
        double discountPercent = 0;

        if (totalAmount >= 1000 && totalAmount <= 4999)
        {
            discountPercent = 10;
        }
        else if (totalAmount >= 5000 && totalAmount <= 9999)
        {
            discountPercent = 20;
        }
        else if (totalAmount >= 10000)
        {
            discountPercent = 30;
        }

        double discount = totalAmount * discountPercent / 100;
        double finalAmount = totalAmount - discount;

        Console.WriteLine("\nTotal Amount : " + totalAmount);
        Console.WriteLine("Discount : " + discount);
        Console.WriteLine("Final Amount : " + finalAmount);

        
        Console.WriteLine("\nChoose Payment");
        Console.WriteLine("1. UPI");
        Console.WriteLine("2. Credit Card");
        Console.WriteLine("3. Debit Card");
        Console.WriteLine("4. Cash on Delivery");

        int paymentChoice = Convert.ToInt32(Console.ReadLine());

        switch (paymentChoice)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                Console.WriteLine("Payment Successful");
                break;

            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
}