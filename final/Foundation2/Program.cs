using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Tom Smith", new Address("Good Street 5", "New City", "YO", "USA"));
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Sandwich", 1, 50, 2));
        order1.AddProduct(new Product("Cola", 2, 50, 1));
        order1.AddProduct(new Product("Potato", 3, 50, 30));
        Console.WriteLine("ORDER 1:\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal cost: ${order1.GetTotalCost()}\n");

        Customer customer2 = new Customer("Don Carlos", new Address("Bad Street 10", "Decent Town", "Nanana", "Wakanda"));
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop", 1, 500, 1));
        order2.AddProduct(new Product("Charger", 2, 50, 3));
        order2.AddProduct(new Product("Phone", 3, 225, 1));
        order2.AddProduct(new Product("Camera", 3, 100, 2));
        Console.WriteLine("ORDER 2:\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal cost: ${order2.GetTotalCost()}\n");
    }
}