using System;
using System.Collections.Generic;

class Program
{
    static List<StationeryItem> items = new List<StationeryItem>();

    static void Main()
    {
        string username = "admin";
        string password = "admin123";
        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter Username: ");
            string u = Console.ReadLine();

            Console.Write("Enter Password: ");
            string p = Console.ReadLine();

            if (u == username && p == password)
            {
                Console.WriteLine("Login Successful");
                break;
            }

            attempts--;
            Console.WriteLine("Invalid Login");
            Console.WriteLine("Attempts Left: " + attempts);

            if (attempts == 0)
            {
                throw new LoginFailedException();
            }
        }

        int choice;

        do
        {
            Console.WriteLine("\n------ Stationery Store ------");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Display Items");
            Console.WriteLine("9. Exit");

            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddItem();
                    break;

                case 2:
                    DisplayItems();
                    break;

                case 9:
                    Console.WriteLine("Thank You. Visit Again.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 9);
    }

    static void AddItem()
    {
        StationeryItem item = new StationeryItem();

        Console.Write("Enter Item Id: ");
        item.ItemId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Item Name: ");
        item.ItemName = Console.ReadLine();

        Console.Write("Enter Category: ");
        item.Category = Console.ReadLine();

        Console.Write("Enter Brand: ");
        item.Brand = Console.ReadLine();

        Console.Write("Enter Price: ");
        item.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        item.Quantity = Convert.ToInt32(Console.ReadLine());

        items.Add(item);

        Console.WriteLine("Item Added Successfully");
    }

    static void DisplayItems()
    {
        foreach (StationeryItem item in items)
        {
            item.DisplayDetails();
            Console.WriteLine("----------------");
        }
    }
}