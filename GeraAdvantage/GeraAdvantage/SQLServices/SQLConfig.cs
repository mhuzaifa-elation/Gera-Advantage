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
        public void CreateTable<T>()
        {
            lock (locker)
            {
                connection.CreateTable<T>();
            }
        }

        public long GetSize()
        {
            return SQLite.GetSize(DatabaseName);
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }
        public void Dispose()
        {
            connection.Dispose();
        }
        public void Commit()
        {
            connection.Commit();
        }

        public bool Update<T>(T item)
        {
            lock (locker)
            {
                int i = connection.Update(item);
                if (i > 0)
                {
                    return true;
                }
                else return false;
            }
        }


        public void ExecuteQuery(string query, object[] args)
        {
            lock (locker)
            {
                connection.Execute(query, args);
            }
        }



        public List<T> Query<T>(string query, object[] args) where T : new()
        {
            lock (locker)
            {
                return connection.Query<T>(query, args);
            }
        }

        public IEnumerable<T> GetItems<T>() where T : new()
        {
            lock (locker)
            {

                return (from i in connection.Table<T>() select i).ToList();
            }
        }

        public int DeleteItem<T>(int id)
        {
            lock (locker)
            {
                return connection.Delete<T>(id);
            }
        }

        public int DeleteAll<T>()
        {
            lock (locker)
            {
                return connection.DeleteAll<T>();
            }
        }

        public bool Insert<T>(T item)
        {
            lock (locker)
            {
                int i = connection.Insert(item);
                if (i > 0)
                {
                    return true;
                }
                else return false;
            }

        }

       
    }
}