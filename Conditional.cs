using System;

class Conditional
{
    public void show()
    {
        int qualityCheck = 0;
        int priorityShipment = 0;
        int normalProcessing = 0;

        for (int packageId = 1001; packageId <= 1020; packageId++)
        {
            Console.Write("Package ID: " + packageId + " - ");

            if (packageId % 4 == 0)
            {
                Console.WriteLine("Quality Check Required");
                qualityCheck++;
            }
            else if (packageId % 5 == 0)
            {
                Console.WriteLine("Priority Shipment");
                priorityShipment++;
            }
            else
            {
                Console.WriteLine("Normal Processing");
                normalProcessing++;
            }
        }

        Console.WriteLine("\n----- Summary -----");
        Console.WriteLine("Total Packages Processed: 20");
        Console.WriteLine("Quality Check Required: " + qualityCheck);
        Console.WriteLine("Priority Shipments: " + priorityShipment);
        Console.WriteLine("Normal Packages: " + normalProcessing);
    }
}