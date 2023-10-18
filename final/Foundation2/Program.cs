using System;

class Program
{
    static void Main(string[] args)
    {        
        //set values in customer and products and orders
        //create customer
        // Customer customer1 = new Customer("Naomi Smith", "1236 Cherry Street", "Los Angeles", "CA", "USA");
        // Product product1A = new Product("Cow Bell","ID056", 15.99, 1);
        // Product product1B = new Product("4pc Red Hat Dining Chair Slipcovers","ID447", 17.88, 3);
        // Product product1C = new Product("Artificial Christmas Wreath","ID244", 39.19, 4);
        // Product product1D = new Product("Christmas Gift Bags", "ID254", 9.99, 5);
        //create order
        Order order1 = new Order();
        order1.SetCustomer("Naomi Smith", "1236 Cherry Street", "Los Angeles", "CA", "USA");

        //add items to order
        order1.OrderItem("Cow Bell","ID056", 15.99, 1);
        order1.OrderItem("4pc Red Hat Dining Chair Slipcovers","ID447", 17.88, 3);
        order1.OrderItem("Artificial Christmas Wreath","ID244", 39.19, 4);
        order1.OrderItem("Christmas Gift Bags", "ID254", 9.99, 5);

        Console.WriteLine($"{order1.GetPackingLabel()}");

    }
}