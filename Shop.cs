using System;
using System.Collections.Generic;
using AutoGladiators.Interfaces;
using ConsoleTables;

namespace AutoGladiators
{
    class Shop : IRoom
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<DbItems> Inventory { get; set; }

        public Shop(List<DbItems> items)
        {
            Id = "01A";
            Name = "Jeff's Shop for Gladiators";
            Description =
                "A shop that has everything a beginner gladiator needs to increase their chance of surviving the arena.";
            Inventory = items;
        }

        public void DisplayItems()
        {
            var table = new ConsoleTable("ID", "Name", "Level", "Description", "Attack", "Attack Speed", "Defence",
                "Type", "Cost");

            foreach (DbItems item in Inventory)
            {
                table.AddRow(item.Id, item.Name, item.Level, item.Description, item.Attack, item.AttackSpeed,
                    item.Defence, item.Type, item.Value);
            }

            table.Write();
        }

        public DbItems SellItem(int itemNo)
        {
            string stringChoice = itemNo.ToString();
            if (Inventory.Exists(i => i.Id.Contains(stringChoice)));
            return Inventory[itemNo];
        }
    }
}
