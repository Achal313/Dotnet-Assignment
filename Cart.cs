using System.Collections.Generic;

class Cart
{
    public List<CartItem> Items = new List<CartItem>();

    public void AddItem(Product p, int qty)
    {
        Items.Add(new CartItem(p, qty));
    }

    public void RemoveItem(Product p)
    {
        foreach (CartItem item in Items)
        {
            if (item.Product.ProductId == p.ProductId)
            {
                Items.Remove(item);
                break;
            }
        }
    }

    public double GetTotal()
    {
        double total = 0;

        foreach (CartItem item in Items)
        {
            total += item.Amount();
        }

        return total;
    }
}