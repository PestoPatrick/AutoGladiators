using System;
using System.Text;
namespace AutoGladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            //import database data first here
            Console.WriteLine("Hello World!");
            Weapon bronzeSword = new Weapon();
            Gladiator gladiator = new Gladiator("Maximus");
            Shop shop = new Shop();
            
            
            gladiator.EquipLeft(bronzeSword);
            Console.WriteLine(gladiator.TotalAttack);

            gladiator.UnEquipLeftWeapon(bronzeSword);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(gladiator.TotalAttack.ToString());
            sb.AppendLine($"The {bronzeSword.Name} is not equipped {bronzeSword.IsEquipped.ToString()}");
            
            shop.Inventory.Add(bronzeSword);
            shop.DisplayItems();
            
            
            Console.WriteLine(sb);
        }
    }
}
