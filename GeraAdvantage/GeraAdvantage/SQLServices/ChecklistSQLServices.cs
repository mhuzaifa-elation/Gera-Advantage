using GeraAdvantage.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeraAdvantage.SQLServices
{
    public class ChecklistSQLServices
    {
        SQLConfig sql_SC;
        public ChecklistSQLServices()
        {
            sql_SC = new SQLConfig();

        }
       
        public List<CheckListType> GetChecklistTypes()
        {
            return sql_SC.GetItems<CheckListType>().ToList();
        }
       
    }
}
