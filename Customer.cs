class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }

    public Customer(int id, string name, string username,
                    string password, string address)
    {
        CustomerId = id;
        Name = name;
        Username = username;
        Password = password;
        Address = address;
    }
}