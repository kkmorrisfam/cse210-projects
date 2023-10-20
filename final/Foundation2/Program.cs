using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

List<Order> orders = new List<Order>();
//set values in customer and products and orders
//create customer
// Customer customer1 = new Customer("Naomi Smith", "1236 Cherry Street", "Los Angeles", "CA", "USA");
//create order
Order order1 = new Order();
order1.SetCustomer("Naomi Smith", "1236 Cherry Street", "Los Angeles", "CA", "USA");


//add items to order
order1.OrderItem("Cow Bell", "ID056", 15.99, 1);
order1.OrderItem("4pc Red Hat Dining Chair Slipcovers", "ID447", 17.88, 3);
order1.OrderItem("Artificial Christmas Wreath", "ID244", 39.19, 4);
order1.OrderItem("Christmas Gift Bags", "ID254", 9.99, 5);
orders.Add(order1);

Order order2 = new Order();
order2.SetCustomer("Robin Hood", "69 Guild Street", "London", "", " United Kingdom");
order2.OrderItem("Crayola Construction Paper", "ID198", 4.99, 2);
order2.OrderItem("Water Color Paper", "ID190", 6.99, 2);
order2.OrderItem("Artist Paint Brush Set", "ID101", 10.99, 1);
orders.Add(order2);

Order order3 = new Order();
order3.SetCustomer("Vicky Turley", "506 N Belmont Street", "Fall River", "MA", "USA");
order3.OrderItem("Artist Paint Brush Set", "ID101", 10.99, 2);
order3.OrderItem("Watercolor Paint Set", "ID128", 44.59, 1);
orders.Add(order3);

Order order4 = new Order();
order4.SetCustomer("Robert Godbold", "1844 Romero Street", "Yuba City", "CA", "USA");
order4.OrderItem("Garden Shears", "ID622", 12.99, 1);
order4.OrderItem("Garden Gloves", "ID601", 16.99, 2);
orders.Add(order4);

//Print Packing Labels       
Console.WriteLine();
Console.WriteLine("Packing Labels:");
Console.WriteLine();
foreach (Order order in orders)
{
    // Console.WriteLine($"{order.GetCustomerName()}");            
    Console.WriteLine($"{order.GetPackingLabel()}");
    double totalPrice = order.GetTotalPrice();
    Console.Write("Total Price:   ");
    Console.WriteLine(totalPrice.ToString("C2", CultureInfo.CurrentCulture));
    Console.WriteLine();
    Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
}

Console.WriteLine();
Console.WriteLine("***********************************");
Console.WriteLine();
Console.WriteLine("Shipping Labels:");
foreach (Order order in orders)
{
    Console.WriteLine($"{order.GetShippingLabel()}");
    Console.WriteLine();
    Console.WriteLine();
}
