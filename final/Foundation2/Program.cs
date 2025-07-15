using System;
public class Program
{
    public static void Main()
    {
        Address addr1 = new Address("166 N 5th W", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Leonardo Alvarino", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "LP1001", 1200.00, 1));
        order1.AddProduct(new Product("Mouse", "MS2001", 25.50, 2));

        Address addr2 = new Address("San luis 1349", "Lima", "LIM", "Peru");
        Customer cust2 = new Customer("Giovani Caceres", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Tablet", "TB3002", 350.00, 1));
        order2.AddProduct(new Product("Charger", "CH4003", 45.00, 1));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order.GetTotalCost());
            Console.WriteLine(new string('-', 40));
        }
    }
}
