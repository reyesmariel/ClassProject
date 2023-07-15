using System;
using System.Linq;
using System.Collections.Generic;

namespace FoodOrderingSystem;

public class FoodMenu
{
    public static List<string> Foods = new List<string>()
        {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Dessert",
            "Snacks"
        };

    public static Dictionary<string, decimal> FoodPrices = new Dictionary<string, decimal>()
        {
            { "Breakfast", 250 },
            { "Lunch", 350 },
            { "Dinner", 450 },
            { "Dessert", 100 },
            { "Snacks", 50 }
        };

    public static Dictionary<string, List<string>> FoodCombos = new Dictionary<string, List<string>>()
        {
            { "Breakfast", new List<string>() {
                 "Sweet Korean Pancake + Coffee Milk" ,
                 "Kimchi Stew + Rice + Boiled Eggs",
                 "Fried Rice + Omelette Eggs + Strawberry Milk"}
            },

            { "Lunch", new List<string>() {
                "Korean Fried Chicken + Rice + Kimchi + Sprite",
                "Fried Rice + Omelette Eggs + Kimchi + Coke",
                "Rice + Main meat + Kimchi +Sprite",
                "Kimchi + Baked Potatoes + Coke + Gimbap" }
            },

            { "Dinner" , new List<string>() {
                "Bulgogi(korean beef barbecue) + Lettuce Wraps + Coke",
                "Mandoo(korean dumplings) + Rice + Sprite",
                "Bossam (korean pork belly) + Lettuce Wraps + Coke",
                "Galbi(korean grilled short ribs) + Lettuce Wraps + Rice + Sprite" }
            },

            { "Dessert", new List<string>() {
                "Tea Cookies + Green Tea",
                "Twisted Donuts + Dalgona Coffee ",
                "Mochi Rice Cake + Makgeolli Ice Cream" }
            },

            { "Snacks", new List<string>() {
                "Bibigo Roasted Seaweeds",
                "Nongshim Chocolate Banana Kick",
                "Orion Market O Rael Brownie",
                "Melona Ice Cream", "Tom's Farm Almond",
                "Lotte Waffle Mate", "Ramyeon" }
            }
        };
}