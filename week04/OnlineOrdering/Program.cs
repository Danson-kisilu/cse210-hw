using System;
using System.Collections.Generic;

namespace OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        // ORDER 1: USA Customer
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Laptop", "T100", 799.99m, 1));
        order1.AddProduct(new Product("Mouse", "M200", 24.99m, 2));
        order1.AddProduct(new Product("Keyboard", "K300", 59.99m, 1));
        
        orders.Add(order1);

        // ORDER 2: International Customer
        Address address2 = new Address("45 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);
        Order order2 = new Order(customer2);
        
        order2.AddProduct(new Product("Phone Case", "P400", 19.99m, 3));
        order2.AddProduct(new Product("Screen Protector", "S500", 9.99m, 2));
        
        orders.Add(order2);

        // ORDER 3: Another USA Customer
        Address address3 = new Address("789 Oak Ave", "Provo", "UT", "USA");
        Customer customer3 = new Customer("Mike Brown", address3);
        Order order3 = new Order(customer3);
        
        order3.AddProduct(new Product("Headphones", "H600", 49.99m, 2));
        order3.AddProduct(new Product("USB Cable", "U700", 7.99m, 3));
        order3.AddProduct(new Product("Webcam", "W800", 89.99m, 1));
        
        orders.Add(order3);

        // Display all orders
        int orderNumber = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"\n==================================================");
            Console.WriteLine($"ORDER #{orderNumber}");
            Console.WriteLine($"==================================================");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"TOTAL COST: ${order.GetTotalCost():F2}");
            orderNumber++;
        }
    }
}