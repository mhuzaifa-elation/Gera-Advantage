using GeraAdvantage.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeraAdvantage.SQLServices
{
    internal class GlobalSQLServices
    {
        SQLConfig sql_SC;
        public GlobalSQLServices()
        {
            sql_SC = new SQLConfig();

        }
        public Building GetBuilding(string Id)
        {
            return sql_SC.GetItems<Building>().FirstOrDefault(x => x.Id == Id);
        }
        public Project GetProject(string Id)
        {
            return sql_SC.GetItems<Project>().FirstOrDefault(x => x.Id == Id);
        }
        public UnitType GetUnit(string Id)
        {
            return sql_SC.GetItems<UnitType>().FirstOrDefault(x => x.Id == Id);
        }
        public RoomType GetRoom(string Id)
        {
            return sql_SC.GetItems<RoomType>().FirstOrDefault(x => x.Id == Id);
        }
        public Floor GetFloor(string Id)
        {
            return sql_SC.GetItems<Floor>().FirstOrDefault(x => x.Id == Id);
        }
        public Category GetCategory(string Id)
        {
            return sql_SC.GetItems<Category>().FirstOrDefault(x => x.Id == Id);
        }
        public RootCause GetRootCause(string Id)
        {
            return sql_SC.GetItems<RootCause>().FirstOrDefault(x => x.Id == Id);
        }
        public Severity GetSeverity(string Id)
        {
            return sql_SC.GetItems<Severity>().FirstOrDefault(x => x.Id == Id);
        }
        public NCStatus GetNCStatus(string Id)
        {
            return sql_SC.GetItems<NCStatus>().FirstOrDefault(x => x.Id == Id);
        }
        public User GetUser(string Id)
        {
            return sql_SC.GetItems<User>().FirstOrDefault(x => x.Id == Id);
        }

        
    }
}
