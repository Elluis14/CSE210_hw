using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("Luis Ramos", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P001", 900.00, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.00, 2));

        DisplayOrder(order1);

        // Second Order
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Ana Lopez", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P003", 700.00, 1));
        order2.AddProduct(new Product("Headphones", "P004", 50.00, 1));
        order2.AddProduct(new Product("Charger", "P005", 20.00, 3));

        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost()}\n");
    }
}
