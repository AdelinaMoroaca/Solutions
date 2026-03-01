using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var customer1 = new Customer { CustomerId = 1, Name = "Alice" };
        var customer2 = new Customer { CustomerId = 2, Name = "Bob" };

        var order1 = new Order { OrderId = 1, OrderDate = DateTime.Now, Customer = customer1 };
        order1.Items.Add(new OrderItem { OrderItemId = 1, ProductName = "Laptop", Quantity = 1, UnitPrice = 600m });
        order1.Items.Add(new OrderItem { OrderItemId = 2, ProductName = "Mouse", Quantity = 2, UnitPrice = 25m });
        customer1.Orders.Add(order1);

        var order2 = new Order { OrderId = 2, OrderDate = DateTime.Now, Customer = customer1 };
        order2.Items.Add(new OrderItem { OrderItemId = 3, ProductName = "Monitor", Quantity = 1, UnitPrice = 200m });
        customer1.Orders.Add(order2);

        var order3 = new Order { OrderId = 3, OrderDate = DateTime.Now, Customer = customer2 };
        order3.Items.Add(new OrderItem { OrderItemId = 4, ProductName = "Keyboard", Quantity = 1, UnitPrice = 100m });
        order3.Items.Add(new OrderItem { OrderItemId = 5, ProductName = "Headphones", Quantity = 1, UnitPrice = 150m });
        order3.Items.Add(new OrderItem { OrderItemId = 6, ProductName = "Mouse", Quantity = 3, UnitPrice = 25m });
        customer2.Orders.Add(order3);

        var customers = new List<Customer> { customer1, customer2 };

        foreach (var customer in customers)
        {
            foreach (var order in customer.Orders)
            {
                decimal finalPrice = order.GetFinalPrice();
                Console.WriteLine($"Customer: {customer.Name}, OrderId: {order.OrderId}, Final price: {finalPrice}€");
            }
        }

        string topSpender = GetTopSpenderName(customers);
        Console.WriteLine($"Top spender: {topSpender}");

        var popularProducts = GetPopularProducts(customers);
        Console.WriteLine("Popular products and total quantity sold:");
        foreach (var product in popularProducts)
        {
            Console.WriteLine($"Product: {product.Key}, Total Quantity Sold: {product.Value}");
        }
    }

    public static string GetTopSpenderName(List<Customer> customers)
    {
        string topCustomerName = null;
        decimal maxSpent = 0;

        foreach (var customer in customers)
        {
            decimal totalSpent = customer.Orders.Sum(order => order.GetFinalPrice());
            if (totalSpent > maxSpent)
            {
                maxSpent = totalSpent;
                topCustomerName = customer.Name;
            }
        }
        return topCustomerName;
    }

    public static Dictionary<string, int> GetPopularProducts(List<Customer> customers)
    {
        var productQuantities = new Dictionary<string, int>();

        foreach (var customer in customers)
        {
            foreach (var order in customer.Orders)
            {
                foreach (var item in order.Items)
                {
                    if (productQuantities.ContainsKey(item.ProductName))
                    {
                        productQuantities[item.ProductName] += item.Quantity;
                    }
                    else
                    {
                        productQuantities[item.ProductName] = item.Quantity;
                    }
                }
            }
        }

        return productQuantities
            .OrderByDescending(p => p.Value)
            .ToDictionary(p => p.Key, p => p.Value);
    }
}