using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public Customer Customer { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public decimal GetFinalPrice()
    {
        decimal total = Items.Sum(item => item.UnitPrice * item.Quantity);
        if (total > 500m)
        {
            total *= 0.9m;  
        }
        return total;
    }
}