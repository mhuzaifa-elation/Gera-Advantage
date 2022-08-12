using GeraAdvantage.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GeraAdvantage.WebServices
{
    public class GlobalWebServices
    {
        public async Task<List<RootCause>> GetRootCauseAsync()
        {
            List<RootCause> RootCauseList = new List<RootCause>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetRootCauseURL());
           var asd=await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, uri)).ConfigureAwait(false);
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                RootCauseList = JsonConvert.DeserializeObject<List<RootCause>>(content);
                return RootCauseList;
            }
            else
            {
                return new List<RootCause>();
            }
        }

        public async Task<List<UnitType>> GetUnitTypeAsync()
        {
            List<UnitType> UnitTypeList = new List<UnitType>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetUnitTypeURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                UnitTypeList = JsonConvert.DeserializeObject<List<UnitType>>(content);
                return UnitTypeList;
            }
            else
            {
                return new List<UnitType>();
            }
        }

        public async Task<List<Severity>> GetSeverityAsync()
        {
            List<Severity> SeverityList = new List<Severity>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetSeverityURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                SeverityList = JsonConvert.DeserializeObject<List<Severity>>(content);
                return SeverityList;
            }
            else
            {
                return new List<Severity>();
            }
        }
        public async Task<List<Category>> GetCategoryAsync()
        {
            List<Category> CategoryList = new List<Category>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetCategoryURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                CategoryList = JsonConvert.DeserializeObject<List<Category>>(content);
                return CategoryList;
            }
            else
            {
                return new List<Category>();
            }
        }
        public async Task<List<CheckListStatusUserRoles>> GetCheckListStatusUserRolesAsync()
        {
            List<CheckListStatusUserRoles> CheckListStatusUserRolesList = new List<CheckListStatusUserRoles>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetCheckListStatusUserRolesURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                CheckListStatusUserRolesList = JsonConvert.DeserializeObject<List<CheckListStatusUserRoles>>(content);
                return CheckListStatusUserRolesList;
            }
            else
            {
                return new List<CheckListStatusUserRoles>();
            }
        }
        public async Task<List<NCStatus>> GetNCStatusAsync()
        {
            List<NCStatus> NCStatusList = new List<NCStatus>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetNCStatusURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                NCStatusList = JsonConvert.DeserializeObject<List<NCStatus>>(content);
                return NCStatusList;
            }
            else
            {
                return new List<NCStatus>();
            }
        }
        public async Task<List<Floor>> GetFloorAsync()
        {
            List<Floor> FloorList = new List<Floor>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetFloorURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                FloorList = JsonConvert.DeserializeObject<List<Floor>>(content);
                return FloorList;
            }
            else
            {
                return new List<Floor>();
            }
        }
        public async Task<List<BuildingFloor>> GetBuildingFloorAsync()
        {
            List<BuildingFloor> BuildingFloorList = new List<BuildingFloor>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetBuildingFloorURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                BuildingFloorList = JsonConvert.DeserializeObject<List<BuildingFloor>>(content);
                return BuildingFloorList;
            }
            else
            {
                return new List<BuildingFloor>();
            }
        }
        public async Task<List<CheckListStages>> GetCheckListStagesAsync()
        {
            List<CheckListStages> CheckListStagesList = new List<CheckListStages>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetCheckListStagesURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                CheckListStagesList = JsonConvert.DeserializeObject<List<CheckListStages>>(content);
                return CheckListStagesList;
            }
            else
            {
                return new List<CheckListStages>();
            }
        }
        public async Task<List<UserRole>> GetUserRoleAsync()
        {
            List<UserRole> UserRoleList = new List<UserRole>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetUserRoleURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                UserRoleList = JsonConvert.DeserializeObject<List<UserRole>>(content);
                return UserRoleList;
            }
            else
            {
                return new List<UserRole>();
            }
        }
        public async Task<List<StructuralMember>> GetStructuralMemberAsync()
        {
            List<StructuralMember> StructuralMemberList = new List<StructuralMember>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetStructuralMemberURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                StructuralMemberList = JsonConvert.DeserializeObject<List<StructuralMember>>(content);
                return StructuralMemberList;
            }
            else
            {
                return new List<StructuralMember>();
            }
        }
        public async Task<List<StatusGroup>> GetStatusGroupAsync()
        {
            List<StatusGroup> StatusGroupList = new List<StatusGroup>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetStatusGroupURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                StatusGroupList = JsonConvert.DeserializeObject<List<StatusGroup>>(content);
                return StatusGroupList;
            }
            else
            {
                return new List<StatusGroup>();
            }
        }
        public async Task<List<UnitTypeRoom>> GetUnitTypeRoomAsync()
        {
            List<UnitTypeRoom> UnitTypeRoomList = new List<UnitTypeRoom>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetUnitTypeRoomURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                UnitTypeRoomList = JsonConvert.DeserializeObject<List<UnitTypeRoom>>(content);
                return UnitTypeRoomList;
            }
            else
            {
                return new List<UnitTypeRoom>();
            }
        }
        public async Task<List<NCStatusRole>> GetNCStatusRoleAsync()
        {
            List<NCStatusRole> NCStatusRoleList = new List<NCStatusRole>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetNCStatusRoleURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                NCStatusRoleList = JsonConvert.DeserializeObject<List<NCStatusRole>>(content);
                return NCStatusRoleList;
            }
            else
            {
                return new List<NCStatusRole>();
            }
        }
        public async Task<List<BuildingUnit>> GetBuildingUnitAsync()
        {
            List<BuildingUnit> BuildingUnitList = new List<BuildingUnit>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetBuildingUnitURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                BuildingUnitList = JsonConvert.DeserializeObject<List<BuildingUnit>>(content);
                return BuildingUnitList;
            }
            else
            {
                return new List<BuildingUnit>();
            }
        }
        public async Task<List<ReadyRecknor>> GetReadyRecknorAsync()
        {
            List<ReadyRecknor> ReadyRecknorList = new List<ReadyRecknor>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetReadyRecknorURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                ReadyRecknorList = JsonConvert.DeserializeObject<List<ReadyRecknor>>(content);
                return ReadyRecknorList;
            }
            else
            {
                return new List<ReadyRecknor>();
            }
        }
        public async Task<List<CheckListType>> GetCheckListTypeAsync()
        {
            List<CheckListType> CheckListTypeList = new List<CheckListType>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetCheckListTypeURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                CheckListTypeList = JsonConvert.DeserializeObject<List<CheckListType>>(content);
                return CheckListTypeList;
            }
            else
            {
                return new List<CheckListType>();
            }
        }
        public async Task<List<Building>> GetBuildingAsync()
        {
            List<Building> BuildingList = new List<Building>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetBuildingURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                BuildingList = JsonConvert.DeserializeObject<List<Building>>(content);
                return BuildingList;
            }
            else
            {
                return new List<Building>();
            }
        }
        public async Task<List<CheckListPointStatus>> GetCheckListPointStatusAsync()
        {
            List<CheckListPointStatus> CheckListPointStatusList = new List<CheckListPointStatus>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetCheckListPointStatusURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                CheckListPointStatusList = JsonConvert.DeserializeObject<List<CheckListPointStatus>>(content);
                return CheckListPointStatusList;
            }
            else
            {
                return new List<CheckListPointStatus>();
            }
        }
        public async Task<List<RoomType>> GetRoomTypeAsync()
        {
            List<RoomType> RoomTypeList = new List<RoomType>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetRoomTypeURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                RoomTypeList = JsonConvert.DeserializeObject<List<RoomType>>(content);
                return RoomTypeList;
            }
            else
            {
                return new List<RoomType>();
            }
        }
        public async Task<List<City>> GetCityAsync()
        {
            List<City> CityList = new List<City>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetCityURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                CityList = JsonConvert.DeserializeObject<List<City>>(content);
                return CityList;
            }
            else
            {
                return new List<City>();
            }
        }
        public async Task<List<Project>> GetProjectAsync()
        {
            List<Project> ProjectList = new List<Project>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetProjectURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                ProjectList = JsonConvert.DeserializeObject<List<Project>>(content);
                return ProjectList;
            }
            else
            {
                return new List<Project>();
            }
        }
        public async Task<List<CheckList>> GetCheckListAsync()
        {
            List<CheckList> CheckListList = new List<CheckList>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetCheckListURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                CheckListList = JsonConvert.DeserializeObject<List<CheckList>>(content);
                return CheckListList;
            }
            else
            {
                return new List<CheckList>();
            }
        }
        public async Task<List<ApprovalCycle>> GetApprovalCycleAsync()
        {
            List<ApprovalCycle> ApprovalCycleList = new List<ApprovalCycle>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetApprovalCycleURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                ApprovalCycleList = JsonConvert.DeserializeObject<List<ApprovalCycle>>(content);
                return ApprovalCycleList;
            }
            else
            {
                return new List<ApprovalCycle>();
            }
        }
    }
}
