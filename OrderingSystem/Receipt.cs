
using System;
using System.Linq;
using System.Collections.Generic;

namespace FoodOrderingSystem;

public class Receipt
{
    public static void PrintReceipt(string customerName, string foodType, decimal foodPrice, decimal paymentAmount, decimal change)
    {
        Console.WriteLine();
        Console.WriteLine("Order Processing...");
        Console.WriteLine();
        Console.WriteLine("          Receipt");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Customer Name : " + customerName);
        Console.WriteLine("Food Type     : " + foodType);
        Console.WriteLine("Total Price   : PHP " + foodPrice);
        Console.WriteLine("Payment Amount: PHP " + paymentAmount);
        Console.WriteLine("Change        : PHP " + change);
        Console.WriteLine("----------------------------");
        Console.WriteLine("\nThank you for your order!");
    }
}