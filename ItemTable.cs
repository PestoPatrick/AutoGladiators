using System;
using ConsoleTables;

namespace AutoGladiators
{
    public class ItemTable
    {
        ConsoleTable itemTable = new ConsoleTable("ID", "Name", "Level", "Description", "Attack", "Attack Speed", "Defence",
            "Type", "Cost");


        public void AddNewRow(DbItems item)
        {
            itemTable.AddRow(item.Id, item.Name, item.Level, item.Description, item.Attack, item.AttackSpeed,
                item.Defence, item.Type, item.Value);
        }

        public ConsoleTable ReturnTable()
        {
            return itemTable;
        }
        
    }
}