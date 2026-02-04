using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("16 Hedsor dr", "Harare", "HRE", "Zimbabwe");
        Customer customer1 = new Customer("Hide Vhunzawabaya", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P200", 25, 2));

        Address address2 = new Address("870 Brooke Villas", "Borrowdale Brooke", "Bk", "Zimbabwe");
        Customer customer2 = new Customer("Prince Mhondera", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P300", 600, 1));
        order2.AddProduct(new Product("Headphones", "P400", 80, 1));
        order2.AddProduct(new Product("Charger", "P500", 20, 2));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice()}");
        Console.WriteLine();
    }
}
