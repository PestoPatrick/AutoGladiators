using ConsoleTables;

namespace AutoGladiators
{
    public class Quarters
    {
        public static void DisplayInventory(Gladiator gladiator)
        {
            ConsoleTable invenTable = new ConsoleTable("ID", "Name", "Level", "Description", "Attack", "Attack Speed", "Defence",
                "Type", "Cost");
            foreach (DbItems item in gladiator.Inventory)
            {
                invenTable.AddRow(item.Id, item.Name, item.Level, item.Description, item.Attack, item.AttackSpeed, item.Defence, item.Type, item.Value);
            }
            invenTable.Write();
        }
    }
}