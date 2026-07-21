using System;

public class InsufficientStockException : Exception
{
    public InsufficientStockException()
        : base("Insufficient stock available.")
    {
    }
}