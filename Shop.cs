using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using AutoGladiators.Interfaces;
using ConsoleTables;

namespace AutoGladiators
{
    class Shop : IRoom
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<object> Inventory { get; set; }

        public Shop()
        {
            Inventory = new List<object>();
        }
        public void DisplayItems()
        {
            var table = new ConsoleTable("ID","Name", "Attack", "Attack Speed", "Defence", "Type", "Cost");
            
            foreach (dynamic item in Inventory )
            {
                Type itemType = item.GetType();
                if (itemType == typeof(Weapon))
                {
                    table.AddRow(item.Id,item.Name,item.Attack,item.AttackSpeed,item.Defence,item.Type,item.Value);
                } else if (itemType == typeof(Armour))
                {
                    table.AddRow(item.Id,item.Name, item.Attack, item.AttackSpeed, item.Defence, item.Type, item.Value);
                }
            
            }
            table.Write();
        }
        public void SellItem()
        {

        }
    
    
    }
}
