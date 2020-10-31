using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SQLite;
using System.Text;



namespace AutoGladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            //import database data first here
            var sqliteConn = DbOperations.CreateConnection();
            SQLiteCommand sqliteCommand = sqliteConn.CreateCommand();
            sqliteCommand.CommandText = "Select * From Items";
            SQLiteDataReader sqliteReader = sqliteCommand.ExecuteReader();
            NameValueCollection collection = new NameValueCollection();
            while (sqliteReader.Read())
            {
                collection.Add(sqliteReader.GetValues());
                Console.WriteLine(sqliteReader.GetValues());
                Console.WriteLine(sqliteReader.GetType());
                
         
            }

            foreach (dynamic row in collection.AllKeys)
            {
                Console.WriteLine(collection[row]);
            }
            Console.WriteLine(collection);
            sqliteConn.Close();

            Console.WriteLine(sqliteConn);
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
