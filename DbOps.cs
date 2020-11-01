using System;
using Microsoft.Data.Sqlite;
namespace AutoGladiators
{
    //class that handles the majority of database operations
    public class DbOperations
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
    }
}