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
            
            //startup operations to to do.
            List<DbItems> dbValues = DbOperations.PullItems();
            Shop shop = new Shop(dbValues);
            StringBuilder builder = new StringBuilder();
            Gladiator gladiator = new Gladiator("Maximus");
            Arena arena = new Arena();
            Quarters quarters = new Quarters();
            bool mainLoop = true;
            while (mainLoop == true)
            { 
                builder.AppendLine("What would you like to do? type the number and press enter");
                builder.AppendLine("1. visit Jeff's Gladiator Shop");
                builder.AppendLine("2. Head to the Arena");
                builder.AppendLine("3. Head to your Private Quarters");
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
                        if (shopAnswer == "1")
                        {
                            Console.WriteLine("Please type the id of the item you would like to purchase");
                            int itemChoice = Int32.Parse(Console.ReadLine() ?? "cancel");
                            if (gladiator.Money > shop.Inventory[itemChoice-1].Value)
                            {
                                DbItems choice = shop.SellItem(itemChoice-1);
                                gladiator.Inventory.Add(choice);
                                Console.WriteLine($"{itemChoice} has been purchased");
                            }
                            else if (gladiator.Money < shop.Inventory[itemChoice-1].Value)
                            {
                                Console.WriteLine($"{gladiator.Name} cannot afford this item");
                            }
                            else
                            {
                                Console.WriteLine("Please enter valid input");
                            }
                        }
                        else if (shopAnswer == "2")
                        {
                            shopping = false;
                        }
                    }
                }
                else if (mainAnswer == "2")
                {
                    string result = Arena.ArenaBattle(gladiator);
                    Console.WriteLine(result);
                }
                else if (mainAnswer == "3")
                {
                    bool quartersLoop = true;
                    while (quartersLoop == true)
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1. Check your inventory and equip an item");
                        Console.WriteLine("2. Check stats");
                        Console.WriteLine("3. Leave quarters");
                        string input = Console.ReadLine();
                        if (input == "1")
                        {
                            // print inventory
                            Quarters.DisplayInventory(gladiator);
                            Console.WriteLine("Would you like to equip a weapon? 1 for yes, 2 for no");
                            string equipchoice = Console.ReadLine();
                            if (equipchoice == "1")
                            {
                                Console.WriteLine(
                                    "What would you like to equip? 1. Left Hand, 2. Right Hand or 3. A two handed");
                                string equipWhereChoice = Console.ReadLine();
                                if (equipWhereChoice == "1")
                                {
                                    Console.WriteLine("What weapon would you like to equip?");
                                    List<DbItems> OneHandWeapons = new List<DbItems>();
                                    ItemTable OneHandTable = new ItemTable();
                                    foreach (DbItems item in gladiator.Inventory)
                                    {
                                        if (item.Type == "OneHanded")
                                        {
                                            OneHandWeapons.Add(item);
                                            OneHandTable.AddNewRow(item);
                                        }
                                    }

                                    ConsoleTable oneWeapTables = OneHandTable.ReturnTable();
                                    oneWeapTables.Write();
                                    Console.WriteLine("Type the Id of the Weapon you want to equip");
                                    int equipChoiceWeapon = Int32.Parse(Console.ReadLine());

                                    gladiator.EquipLeft(gladiator.Inventory[equipChoiceWeapon - 1]);
                                    Console.WriteLine(gladiator.LeftHand);
                                }
                                else if (equipWhereChoice == "2")
                                {
                                    Console.WriteLine("What weapon would you like to equip?");
                                    List<DbItems> OneHandWeapons = new List<DbItems>();
                                    ItemTable OneHandTable = new ItemTable();
                                    foreach (DbItems item in gladiator.Inventory)
                                    {
                                        if (item.Type == "OneHanded")
                                        {
                                            OneHandWeapons.Add(item);
                                            OneHandTable.AddNewRow(item);
                                        }
                                    }

                                    ConsoleTable oneWeapTables = OneHandTable.ReturnTable();
                                    oneWeapTables.Write();
                                    Console.WriteLine("Type the Id of the Weapon you want to equip");
                                    int equipChoiceWeapon = Int32.Parse(Console.ReadLine());

                                    gladiator.EquipRight(gladiator.Inventory[equipChoiceWeapon - 1]);
                                    Console.WriteLine(gladiator.LeftHand);
                                } else if (equipWhereChoice == "2")
                                {
                                    Console.WriteLine("What weapon would you like to equip?");
                                    List<DbItems> TwoHandWeapons = new List<DbItems>();
                                    ItemTable TwoHandTable = new ItemTable();
                                    foreach (DbItems item in gladiator.Inventory)
                                    {
                                        if (item.Type == "TwoHanded")
                                        {
                                            TwoHandWeapons.Add(item);
                                            TwoHandTable.AddNewRow(item);
                                        }
                                    }

                                    ConsoleTable oneWeapTables = TwoHandTable.ReturnTable();
                                    oneWeapTables.Write();
                                    Console.WriteLine("Type the Id of the Weapon you want to equip");
                                    int equipChoiceWeapon = Int32.Parse(Console.ReadLine());
                                    
                                    gladiator.EquipTwoHanded(gladiator.Inventory[equipChoiceWeapon - 1]);
                                    Console.WriteLine(gladiator.LeftHand);
                                }
                            }
                        }
                        else if (input == "2")
                        {
                            // check stats
                        }
                        else if (input == "3")
                        {
                            // quit program
                            quartersLoop = false;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid input");
                        }
                        
                    }
                    
                }
                
                
                
                else if (mainAnswer == "9")
                {
                    mainLoop = false;
                }
            }
        }
    }
}