using System;
using System.Collections.Generic;

namespace AutomobileVehicleManagementSystem
{
    class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehicleName { get; set; }
        public string VehicleType { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
    }

    class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();

        static void Main(string[] args)
        {
            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            string empId = Console.ReadLine();

            Console.WriteLine($"\nWelcome {empName}");

            int choice;

            do
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine("ABC MOTORS");
                Console.WriteLine("Vehicle Management System");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. View All Vehicles");
                Console.WriteLine("3. Search Vehicle");
                Console.WriteLine("4. Update Vehicle Price");
                Console.WriteLine("5. Delete Vehicle");
                Console.WriteLine("6. Calculate Discount");
                Console.WriteLine("7. Show Vehicle Details");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddVehicle();
                        break;

                    case 2:
                        ViewVehicles();
                        break;

                    case 3:
                        SearchVehicle();
                        break;

                    case 4:
                        UpdatePrice();
                        break;

                    case 5:
                        DeleteVehicle();
                        break;

                    case 6:
                        CalculateDiscount();
                        break;

                    case 7:
                        ShowVehicleDetails();
                        break;

                    case 8:
                        Console.WriteLine("Thank you for using ABC Motors System.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 8);
        }

        static void AddVehicle()
        {
            Vehicle v = new Vehicle();

            Console.Write("Enter Vehicle ID: ");
            v.VehicleID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Vehicle Name: ");
            v.VehicleName = Console.ReadLine();

            Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
            v.VehicleType = Console.ReadLine();

            Console.Write("Enter Brand: ");
            v.Brand = Console.ReadLine();

            Console.Write("Enter Price: ");
            v.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Manufacturing Year: ");
            v.Year = Convert.ToInt32(Console.ReadLine());

            vehicles.Add(v);

            Console.WriteLine("Vehicle Added Successfully!");
        }

        static void ViewVehicles()
        {
            if (vehicles.Count == 0)
            {
                Console.WriteLine("No vehicles available.");
                return;
            }

            Console.WriteLine("\n------------------------------------------------------------------");
            Console.WriteLine("ID\tName\t\tBrand\t\tType\tPrice");
            Console.WriteLine("------------------------------------------------------------------");

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine($"{v.VehicleID}\t{v.VehicleName}\t\t{v.Brand}\t\t{v.VehicleType}\t{v.Price}");
            }
        }

        static void SearchVehicle()
        {
            Console.Write("Enter Vehicle ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Vehicle v = vehicles.Find(x => x.VehicleID == id);

            if (v != null)
            {
                Console.WriteLine("\nVehicle Found");
                Console.WriteLine("ID : " + v.VehicleID);
                Console.WriteLine("Name : " + v.VehicleName);
                Console.WriteLine("Brand : " + v.Brand);
                Console.WriteLine("Type : " + v.VehicleType);
                Console.WriteLine("Price : " + v.Price);
                Console.WriteLine("Year : " + v.Year);
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }

        static void UpdatePrice()
        {
            Console.Write("Enter Vehicle ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Vehicle v = vehicles.Find(x => x.VehicleID == id);

            if (v != null)
            {
                Console.Write("Enter New Price: ");
                v.Price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Price Updated Successfully!");
            }
            else
            {
                Console.WriteLine("Vehicle ID does not exist.");
            }
        }

        static void DeleteVehicle()
        {
            Console.Write("Enter Vehicle ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Vehicle v = vehicles.Find(x => x.VehicleID == id);

            if (v != null)
            {
                vehicles.Remove(v);
                Console.WriteLine("Vehicle Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Vehicle not available.");
            }
        }

        static void CalculateDiscount()
        {
            Console.Write("Enter Vehicle ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Vehicle v = vehicles.Find(x => x.VehicleID == id);

            if (v != null)
            {
                double discount = 0;

                if (v.VehicleType.ToLower() == "car")
                {
                    discount = v.Price * 0.10;
                }
                else if (v.VehicleType.ToLower() == "bike")
                {
                    discount = v.Price * 0.05;
                }
                else if (v.VehicleType.ToLower() == "truck")
                {
                    discount = v.Price * 0.12;
                }

                double finalPrice = v.Price - discount;

                Console.WriteLine("Vehicle Price : " + v.Price);
                Console.WriteLine("Discount : " + discount);
                Console.WriteLine("Final Price : " + finalPrice);
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }

        static void ShowVehicleDetails()
        {
            Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
            string type = Console.ReadLine().ToLower();

            switch (type)
            {
                case "car":
                    Console.WriteLine("Car is a four wheeler.");
                    Console.WriteLine("Suitable for family.");
                    break;

                case "bike":
                    Console.WriteLine("Bike is fuel efficient.");
                    Console.WriteLine("Suitable for city rides.");
                    break;

                case "truck":
                    Console.WriteLine("Truck is used for transportation.");
                    Console.WriteLine("Heavy load vehicle.");
                    break;

                default:
                    Console.WriteLine("Invalid Vehicle Type.");
                    break;
            }
        }
    }
}