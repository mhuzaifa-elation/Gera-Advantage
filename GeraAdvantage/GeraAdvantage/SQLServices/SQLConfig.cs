using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace GeraAdvantage.SQLServices
{
    public class SQLConfig
    {
        static readonly object locker = new object();
        SQLiteService SQLite = new SQLiteService();

        readonly SQLiteConnection connection;
        readonly string DatabaseName;

        public SQLConfig()
        {
            DatabaseName = SQLiteService.defaultDBName;
            connection = SQLite.GetConnection(DatabaseName);
        }

        public SQLConfig(string databaseName)
        {
            DatabaseName = databaseName;
            connection = SQLite.GetConnection(DatabaseName);
        }


        public IEnumerable<T> GetItems<T>() where T : new()
        {
            lock (locker)
            {
                return (from i in connection.Table<T>() select i).ToList();
            }
        }
    }
}