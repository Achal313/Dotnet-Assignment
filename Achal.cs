// See https://aka.ms/new-console-template for more information

using System;

class Grade
{
    public void show()
    {
        int marks;

        Console.Write("Enter student marks: ");
        marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 75)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 35)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}