class Payment
{
    public string PaymentMode { get; set; }
    public string Status { get; set; }

    public Payment(string mode)
    {
        PaymentMode = mode;
        Status = "Success";
    }

    public void Display()
    {
        System.Console.WriteLine(
        "Payment Mode : " + PaymentMode);
        System.Console.WriteLine(
        "Status : " + Status);
    }
}