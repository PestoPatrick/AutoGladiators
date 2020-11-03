using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Text;
using ConsoleTables;


namespace AutoGladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mainLoop = true;
            while (mainLoop == true)
            {
                //startup operations to to do.
                List<DbItems> dbValues = DbOperations.PullItems();
                Shop shop = new Shop(dbValues);
                StringBuilder builder = new StringBuilder();
                Gladiator gladiator = new Gladiator("Maximus");
                Arena arena = new Arena();

                builder.AppendLine("What would you like to do? type the number and press enter");
                builder.AppendLine("1. visit Jeff's Gladiator Shop");
                builder.AppendLine("2. Head to the Arena");
                builder.AppendLine("9. Quit the game.");
                Console.WriteLine(builder);
                string mainAnswer = Console.ReadLine();
                if (mainAnswer == "1")
                {
                    bool shopping = true;
                    while (shopping)
                    {
                        StringBuilder shopBuilder = new StringBuilder();

                        shop.DisplayItems();
                        shopBuilder.AppendLine("Would you like to make a purchase? Type y or n");
                        Console.WriteLine(shopBuilder);
                        string shopAnswer = Console.ReadLine();
                        if (shopAnswer == "y")
                        {
                            Console.WriteLine("Please type the id of the item you would like to purchase");
                            int itemChoice = Int32.Parse(Console.ReadLine() ?? "cancel");
                            if (gladiator.Money < shop.Inventory[itemChoice].Value)
                            {
                                gladiator.Inventory.Add(shop.Inventory[itemChoice]);
                            }
                        }
                        else if (shopAnswer == "n")
                        {
                            shopping = false;
                        }
                    }
                }
                else if (mainAnswer == "9")
                {
                    mainLoop = false;
                }
                else if (mainAnswer == "2")
                {
                    string result = Arena.ArenaBattle(gladiator);
                    Console.WriteLine(result);
                }

                Weapon bronzeSword = new Weapon();
            }
        }
    }
}