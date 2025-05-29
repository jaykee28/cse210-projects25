class Program
{
    static void Main()
    {
        // Create Customers
        Customer customer1 = new Customer("John Logan", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Albert Bungane", new Address("456 Maple Ave", "Toronto", "ON", "Canada"));

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M456", 49.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P789", 699.99, 1));
        order2.AddProduct(new Product("Headphones", "H101", 199.99, 1));

        // Display Order Details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}\n");
    }
}
