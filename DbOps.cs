using System;
using System.Data.SQLite;
namespace AutoGladiators
{
    //class that handles the majority of database operations
    public class DbOperations
    {
        public static SQLiteConnection CreateConnection()
        {
            
            var sqliteConn = new SQLiteConnection("Data Source=/Users/patrick/Documents/code/src/github.com/PestoPatrick/AutoGladiators/AGItems.db;");
            
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