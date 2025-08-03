using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; }
    public string ProductId { get; }
    public decimal Price { get; }
    public int Quantity { get; }

    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public decimal TotalCost()
    {
        return Price * Quantity;
    }
}

public class Address
{
    public string Street { get; }
    public string City { get; }
    public string StateOrProvince { get; }
    public string Country { get; }

    public Address(string street, string city, string stateOrProvince, string country)
    {
        Street = street;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.Trim().ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {StateOrProvince}\n{Country}";
    }
}

public class Customer
{
    public string Name { get; }
    public Address Address { get; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }
}

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }

        // Add shipping fee
        total += customer.LivesInUSA() ? 5m : 35m;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address.GetFullAddress()}";
    }
}

class Program
{
    static void Main()
    {
        // First Order
        Address addr1 = new Address("12 Ocean Drive", "Miami", "FL", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Pen", "P101", 1.50m, 10));
        order1.AddProduct(new Product("Notebook", "N202", 3.00m, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        // Second Order
        Address addr2 = new Address("88 King St", "London", "ENG", "UK");
        Customer cust2 = new Customer("Bob Smith", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Binder", "B303", 5.00m, 2));
        order2.AddProduct(new Product("Eraser", "E404", 0.75m, 4));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}