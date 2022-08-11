using System;
using System.Collections.Generic;
using System.Text;

namespace GeraAdvantage.Utils
{
    public static class URLManager
    {
        private static string GetServiceURL(string serviceName)
        {
            string url = string.Format("ttps://windows.ishatechnohub.in/api/{0}", serviceName);
            //DomainName = enSettings.DomainName;
            return url;
        }
        internal static string GetRootCauseURL()
        {
            return GetServiceURL("RootCause");
        }
    }
}
