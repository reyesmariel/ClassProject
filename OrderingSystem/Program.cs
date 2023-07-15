using System;
using System.Collections.Generic;

namespace FoodOrderingSystem;

class Program
{
    static void Main()
    {
        bool Exit = false;
        while (!Exit)
        {

            Console.WriteLine("Welcome to the Taste Of Korea!");

            DisplayFoods();

            int choice = UserInput.GetFoodChoice();

            if (choice < 1 || choice > FoodMenu.Foods.Count)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            string selectedFood = FoodMenu.Foods[choice - 1];
            List<string> comboOptions = FoodMenu.FoodCombos[selectedFood];

            Console.WriteLine("\nYou have selected: " + selectedFood);
            Console.WriteLine("\nPlease select the combo option:");

            int comboChoice = UserInput.GetComboChoice(comboOptions);

            if (comboChoice < 1 || comboChoice > comboOptions.Count)
            {
                Console.WriteLine("Invalid combo choice!");
                return;
            }

            string selectedCombo = comboOptions[comboChoice - 1];
            string foodType = $"{selectedFood} ({selectedCombo})";

            decimal foodPrice = FoodMenu.FoodPrices[selectedFood];
            Console.WriteLine("\nTotal Price: PHP " + foodPrice);

            string customerName = UserInput.GetCustomerName();
            Console.WriteLine();
            Console.WriteLine($"Thank you, {customerName}!");

            decimal paymentAmount = UserInput.GetPaymentAmount(foodPrice);

            if (paymentAmount < foodPrice)
            {
                Console.WriteLine("Insufficient payment!");
                return;
            }

            decimal change = paymentAmount - foodPrice;
            Console.WriteLine("\nPayment successful!");
            Console.WriteLine("\nYour change: PHP " + change);

            Receipt.PrintReceipt(customerName, foodType, foodPrice, paymentAmount, change);

            Console.WriteLine();
            Console.WriteLine("Do you want to order again? (yes/no)");
            Console.Write("Enter your choice: ");
            string exit = Console.ReadLine();

            if (exit == "yes")
            {
                continue;
            }
            else if (exit == "no")
            {
                Exit = true;
                Console.WriteLine("\nPlease come again!");
                break;
            }
        }

    }

    static void DisplayFoods()
    {
        Console.WriteLine("\nType of food you want to order:");

        for (int i = 0; i < FoodMenu.Foods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {FoodMenu.Foods[i]}");
        }
    }
}