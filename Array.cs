using System;

class Array
{
    static void show()
    {
        int sum = 0;

        int[] employee = { 1, 2, 3, 4, 5, 6 };
        int[] sales = { 10000, 20000, 30000, 40000, 50000, 60000 };

        int highest = sales[0];
        int lowest = sales[0];

        for (int i = 0; i < employee.Length; i++)
        {
            Console.WriteLine(employee[i] + "=" + sales[i]);

            sum += sales[i];

            if (sales[i] > highest)
                highest = sales[i];

            if (sales[i] < lowest)
                lowest = sales[i];
        }

        double average = (double)sum / sales.Length;

        Console.WriteLine("Total sales of all employees is: " + sum);
        Console.WriteLine("Average sales is: " + average);
        Console.WriteLine("Highest sales is: " + highest);
        Console.WriteLine("Lowest sales is: " + lowest);
    }
}