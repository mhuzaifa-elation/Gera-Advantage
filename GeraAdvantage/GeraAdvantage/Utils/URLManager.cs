using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GeraAdvantage.Utils
{
    public static class URLManager
    {
        private static string GetServiceURL(string serviceName)
        {
            string url = string.Format("https://windowsdev.in/Api/{0}/GetAll", serviceName);
            //DomainName = enSettings.DomainName;
            return url;
        }
        internal static string GetRootCauseURL()
        {
            return GetServiceURL("RootCause");
        }
        internal static string GetUnitTypeURL()
        {
            return GetServiceURL("UnitType");
        }

        internal static string GetUserURL()
        {
            return GetServiceURL("User");
        }
        internal static string GetLoginURL(string username,string Password, string DeviceID)
        {
            return string.Format("https://windowsdev.in/api/User/ValidateLogin?userName={0}&password={1}&deviceid={2}",username,Password,DeviceID);
        }

        internal static string GetSeverityURL()
        {
            return GetServiceURL("Severity");
        }
        internal static string GetCategoryURL()
        {
            return GetServiceURL("Category");
        }
        internal static string GetCheckListStatusUserRolesURL()
        {
            return GetServiceURL("CheckListStatusUserRoles");
        }
        internal static string GetNCStatusURL()
        {
            return GetServiceURL("NCStatus");
        }
        internal static string GetFloorURL()
        {
            return GetServiceURL("Floor");
        }
        internal static string GetBuildingFloorURL()
        {
            return GetServiceURL("BuildingFloor");
        }
        internal static string GetCheckListStagesURL(int CheckListTypeId)
        {
            return string.Format("https://windowsdev.in/api/CheckListType/GetStages?checkListTypeId={0}", CheckListTypeId);

        }
        internal static string GetUserRoleURL()
        {
            return GetServiceURL("UserRole");
        }
        internal static string GetStructuralMemberURL()
        {
            return GetServiceURL("StructuralMember");
        }
        internal static string GetStatusGroupURL()
        {
            return GetServiceURL("StatusGroup");
        }
        internal static string GetUnitTypeRoomURL()
        {
            return GetServiceURL("UnitTypeRoom");
        }
        internal static string GetNCStatusRoleURL()
        {
            return GetServiceURL("NCStatusRole");
        }
        internal static string GetBuildingUnitURL()
        {
            return GetServiceURL("BuildingUnit");
        }
        internal static string GetNCURL()
        {
            return GetServiceURL("NC");
        }
        internal static string GetReadyRecknorURL()
        {
            return GetServiceURL("ReadyRecknor");
        }
        internal static string GetCheckListTypeURL()
        {
            return GetServiceURL("CheckListType");
        }
        internal static string GetBuildingURL()
        {
            return GetServiceURL("Building");
        }
        internal static string GetCheckListPointStatusURL()
        {
            return GetServiceURL("CheckListPointStatus");
        }
        internal static string GetCheckListPointStatusURL(int checklisttypeId, int categoryId)
        {
            return string.Format("https://windowsdev.in/api/CheckListType/GetCheckPoints?checklistTypeId={0}&categoryId={1}", checklisttypeId, categoryId);
        }
        internal static string GetRoomTypeURL()
        {
            return GetServiceURL("RoomType");
        }
        internal static string GetCityURL()
        {
            return GetServiceURL("City");
        }
        internal static string GetProjectURL()
        {
            return GetServiceURL("Project");
        }
        internal static string GetCheckListURL()
        {
            return GetServiceURL("CheckList");
        }
        internal static string GetApprovalCycleURL()
        {
            return GetServiceURL("ApprovalCycle");
        }

    }
}
