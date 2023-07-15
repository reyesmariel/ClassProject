using System;
using System.Linq;
using System.Collections.Generic;

namespace FoodOrderingSystem;

public class UserInput
{
    public static int GetFoodChoice()
    {
        Console.Write("\nEnter your food of choice: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int GetComboChoice(List<string> comboOptions)
    {
        for (int i = 0; i < comboOptions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {comboOptions[i]}");
        }

        Console.Write("\nEnter your combo choice: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static string GetCustomerName()
    {
        Console.Write("\nEnter your name: ");
        return Console.ReadLine();
    }

    public static decimal GetPaymentAmount(decimal foodPrice)
    {
        Console.Write("\nEnter your payment amount: PHP ");
        return decimal.Parse(Console.ReadLine());
    }
}
