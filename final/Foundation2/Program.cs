public class Program
{
    public static void Main()
    {
        var product1 = new Product("Laptop", "P1001", 999.99, 1);
        var product2 = new Product("Mouse", "P1002", 19.99, 2);
        var product3 = new Product("Keyboard", "P1003", 49.99, 1);
        var product4 = new Product("Monitor", "P1004", 199.99, 1);
        var product5 = new Product("Headphones", "P1005", 79.99, 1);

        var address1 = new Address("123 Tortuga St", "Orlando", "FL", "USA");
        var customer1 = new Customer("Jack Sparrow", address1);
        var order1 = new Order(new List<Product> { product1, product2, product3 }, customer1);

        var address2 = new Address("4 Private Drive", "Little Whinging", "Surrey", "England");
        var customer2 = new Customer("Harry Potter", address2);
        var order2 = new Order(new List<Product> { product4, product5 }, customer2);

        var orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
        }
    }
}