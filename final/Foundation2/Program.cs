using System;

class Program
{
    static void Main(string[] args)
    {
        Order orderOne = new Order("Kyle", "2398 Alkaline St", "Salem", "Ohio", "23984", "USA");
        Order orderTwo = new Order("Jeff", "102 Cream St", "Olivia", "Vermont", "12398", "NOT-USA");
        orderOne.AddProduct("Bulk Toilet paper", "tp-783", 17.99, 5);
        orderOne.AddProduct("Bulk Peanuts", "pn-12345", 10.99, 20);
        orderTwo.AddProduct("Grill", "g-2938", 308.99, 1);
        orderTwo.AddProduct("Smoker", "g-523", 212.99, 1);
        PrintOrder(orderOne);
        PrintOrder(orderTwo);
    }
    static void PrintOrder(Order order)
    {
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${Convert.ToString(order.TotalCost())}");
        Console.WriteLine();
    }
}