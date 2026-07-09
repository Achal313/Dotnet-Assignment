using System;
using System.Collections.Generic;

class ListDemo
{
    static void Main()
    {
        List<string> books = new List<string>()
        {
            "C#",
            "Java",
            "Python",
            "SQL"
        };

        Console.WriteLine("Available Books:");

        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        books.Add("ASP.NET");
        books.Remove("Java");

        Console.WriteLine("\nUpdated Book List:");

        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nTotal Number of Books: " + books.Count);
    }
}