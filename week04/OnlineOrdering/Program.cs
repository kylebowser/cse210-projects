using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1145 randal ave", "PortLand", "Oregan", "USA");
        Customer customer1 = new Customer("Thomas Sol", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Bread", 12354, 5.99, 2);
        order1.SetProduct(product1);
        Product product2 = new Product("Soda", 34895, 0.99, 12);
        order1.SetProduct(product2);
        Product product3 = new Product("Meat", 98753, 10, 1);
        order1.SetProduct(product3);

        Address address2 = new Address("234 W 456 N", "Alpache", "Cancoon", "Mexico");
        Customer customer2 = new Customer("Danny Carro", address2);
        Order order2 = new Order(customer2);
        Product product21 = new Product("Candle", 83475, 18.55, 3);
        order2.SetProduct(product21);
        Product product22 = new Product("BathMat", 93485, 21.99, 1);
        order2.SetProduct(product22);
        Product product23 = new Product("BathBomb", 63728, 8.11, 4);
        order2.SetProduct(product23);

        Console.WriteLine($"{order1.PackingLabel()}");
        Console.WriteLine($"{order1.ShippingLabel()}");
        Console.WriteLine($"Price: ${order1.TotalCost():F2}");

        Console.WriteLine();

        Console.WriteLine($"{order2.PackingLabel()}");
        Console.WriteLine($"{order2.ShippingLabel()}");
        Console.WriteLine($"Price: ${order2.TotalCost():F2}");

    }
}