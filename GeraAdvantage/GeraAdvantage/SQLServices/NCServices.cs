using GeraAdvantage.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeraAdvantage.SQLServices
{
    public class NCServices
    {
        public bool SaveNC(NC nC)
        {
                bool ret = false;
            try
            {
                SQLConfig config = new SQLConfig();
                ret = config.Insert(nC);
                return ret;
            }
            catch (Exception ex)
            {
                return ret;
            }
        }
    }
}
