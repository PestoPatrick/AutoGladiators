using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Text;
using ConsoleTables;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;


namespace AutoGladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new ConsoleTable("1", "2", "3", "4", "5", "6", "7", "8", "9","10");
            //import database data first here
            //got to convert this to use the microsoft.data.sqlite package
            // as it seems the abstraction is quicker to learn and implement
            var sqliteConn = DbOperations.CreateConnection();
            SqliteCommand sqliteCommand = sqliteConn.CreateCommand();
            sqliteCommand.CommandText = "Select * From Items";
            SqliteDataReader sqliteReader = sqliteCommand.ExecuteReader();
            NameValueCollection collection = new NameValueCollection();
            //this method doesn't work but maybe it will soon 😍
            // int fieldCount = sqliteReader.GetValues(values);
            // Console.WriteLine("sqliteReader.GetValues retrieved {0} columns", fieldCount);
            // for (int i = 0; i < fieldCount; i++)
            // {
            //     Console.WriteLine(values[i]);
            // }
            List<DbItems> values = new List<DbItems>();
            while (sqliteReader.Read())
            {
                var row = new DbItems();
                row.Id = sqliteReader.GetString(0);
                row.Name = sqliteReader.GetString(1);
                row.Level = sqliteReader.GetInt32(2);
                row.Description = sqliteReader.GetString(3);
                row.IsEquipped = sqliteReader.GetBoolean(4);
                row.Type = sqliteReader.GetString(5);
                row.Value = sqliteReader.GetInt32(6);
                row.Attack = sqliteReader.GetInt32(7);
                row.AttackSpeed = sqliteReader.GetFloat(8);
                row.Defence = sqliteReader.GetInt32(9);
                values.Add(row);
            }

            values.ForEach(Console.WriteLine);

            Console.WriteLine(JsonConvert.SerializeObject(values, (Newtonsoft.Json.Formatting) Formatting.Indented));            
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
            table.Write();
            
            
            Console.WriteLine(sb);
        }
    }
}
