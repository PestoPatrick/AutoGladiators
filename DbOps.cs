using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
namespace AutoGladiators
{
    //class that handles the majority of database operations
    public static class DbOperations
    {
        public static SqliteConnection CreateConnection()
        {
            
            var sqliteConn = new SqliteConnection("Data Source=/Users/patrick/Documents/code/src/github.com/PestoPatrick/AutoGladiators/AGItems.db;");
            
            try
            {
                sqliteConn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return sqliteConn;
        }

        public static List<DbItems> PullItems()
        {
            SqliteConnection sqliteConn = CreateConnection();
            SqliteCommand sqliteCommand = sqliteConn.CreateCommand();
            sqliteCommand.CommandText = "Select * From Items";
            SqliteDataReader sqliteReader = sqliteCommand.ExecuteReader();
            List<DbItems> values = new List<DbItems>();
            
            while (sqliteReader.Read())
            {
                var row = new DbItems
                {
                    Id = sqliteReader.GetString(0),
                    Name = sqliteReader.GetString(1),
                    Level = sqliteReader.GetInt32(2),
                    Description = sqliteReader.GetString(3),
                    IsEquipped = sqliteReader.GetBoolean(4),
                    Type = sqliteReader.GetString(5),
                    Value = sqliteReader.GetInt32(6),
                    Attack = sqliteReader.GetInt32(7),
                    AttackSpeed = sqliteReader.GetFloat(8),
                    Defence = sqliteReader.GetInt32(9)
                };
                values.Add(row);
            }
            sqliteConn.Close();
            return values;

        }
    }
}