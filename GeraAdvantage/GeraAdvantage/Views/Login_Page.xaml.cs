using GeraAdvantage.SQLServices;
using GeraAdvantage.Utils;
using GeraAdvantage.Views;
using ModernHttpClient;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static GeraAdvantage.Utils.Entities;
using Project = GeraAdvantage.Utils.Project;

namespace GeraAdvantage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login_Page : ContentPage
    {
        public Login_Page()
        {
            string LicKey = "NjUwOTUxQDMyMzAyZTMxMmUzMGhyWkZGSW9hWVdTTkZid2FucFBDV3dKWVh0NnpOa1pLVFB5QmpDcW5jTjg9";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(LicKey);
            InitializeComponent();
            InitializeTempSQLData();
        }
        public async Task<List<RootCause>> GetRootCauseAsync()
        {
            List<RootCause> rootCauseList = new List<RootCause>();
            HttpClient client = UtilServices.GetHttpClient();

            Uri uri = new Uri(URLManager.GetRootCauseURL());
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                rootCauseList= JsonConvert.DeserializeObject<List<RootCause>>(content);
                return rootCauseList;
            }
            else
            {
                return new List<RootCause>();
            }


            //HEADER COMMENT

            //string parameters = string.Format("BilletCount={0}&BilletGrade={4}&Date={1}&MeltCount={2}&Tonage={3}");
            //                                     //, BiletNum, date.ToString("yyyy-MM-dd HH:MM:ss"), MeltCount, Tonage, BilletGrade);
            //var request = new HttpRequestMessage(HttpMethod.Post, new Uri("URL"));
            //if (parameters != null)
            //    request.Content = new StringContent(parameters, Encoding.UTF8, "application/json");
            //var responsse = client.SendAsync(request);

        }
        private void InitializeTempSQLData()
        {
            try
            {


                var RootcauseStr = GetRootCauseAsync().Result;
                SQLConfig config = new SQLConfig();
                if (!config.GetItems<UserRole>().Any())
                {
                    config.DeleteAll<User>("User");
                    config.Insert(new User() { Id = "1", Title = "Test User" });
                    config.Insert(new User() { Id = "2", Title = "Test Contractor" });

                    config.DeleteAll<UserRole>("UserRole");
                    config.Insert(new UserRole() { Id = "1", Title = "Site Engineer" });
                    config.Insert(new UserRole() { Id = "2", Title = "QA" });
                    config.Insert(new UserRole() { Id = "3", Title = "Contractor" });


                    config.DeleteAll<City>("City");
                    config.Insert(new City() { Id = "1", Name = "Pune" });
                    config.Insert(new City() { Id = "2", Name = "Goa" });
                    config.Insert(new City() { Id = "3", Name = "Mumbai" });


                    config.DeleteAll<Project>("Project");
                    config.Insert(new Project() { Id = "1", Name = "Osis", CityId = 1, Address = "Shivaji Nagar, Pune" });
                    config.Insert(new Project() { Id = "2", Name = "EmerLand", CityId = 1, Address = "Chinchvar, Pune" });



                    config.DeleteAll<Floor>("Floor");
                    config.Insert(new Floor() { Id = "1", Title = "First Floor", FloorNo = 1 });
                    config.Insert(new Floor() { Id = "2", Title = "Second Floor", FloorNo = 2 });
                    config.Insert(new Floor() { Id = "3", Title = "Basement", FloorNo = -1 });
                    config.Insert(new Floor() { Id = "4", Title = "Ground Floor", FloorNo = 0 });


                    config.DeleteAll<RoomType>("RoomType");
                    config.Insert(new RoomType() { Id = "1", Title = "Bedroom" });
                    config.Insert(new RoomType() { Id = "2", Title = "Hall" });
                    config.Insert(new RoomType() { Id = "3", Title = "Bedroom Balcony" });
                    config.Insert(new RoomType() { Id = "4", Title = "Lift Room" });
                    config.Insert(new RoomType() { Id = "5", Title = "Toilet" });

                    config.DeleteAll<StatusGroup>("StatusGroup");
                    config.Insert(new StatusGroup() { Id = "1", Title = "Open" });
                    config.Insert(new StatusGroup() { Id = "2", Title = "In Progress" });
                    config.Insert(new StatusGroup() { Id = "3", Title = "Completed" });
                    config.Insert(new StatusGroup() { Id = "4", Title = "Rejected" });
                    config.Insert(new StatusGroup() { Id = "5", Title = "Cancelled" });

                    config.DeleteAll<NCStatus>("NCStatus");
                    config.Insert(new NCStatus() { Id = "1", Title = "Open", StatusGroupId = 1 });
                    config.Insert(new NCStatus() { Id = "2", Title = "In Progress", StatusGroupId = 2 });
                    config.Insert(new NCStatus() { Id = "3", Title = "Completed", StatusGroupId = 3 });
                    config.Insert(new NCStatus() { Id = "4", Title = "Cancelled", StatusGroupId = 5 });
                    config.Insert(new NCStatus() { Id = "5", Title = "Completed by Other Contractor", StatusGroupId = 3 });
                    config.Insert(new NCStatus() { Id = "6", Title = "Work Done", StatusGroupId = 2 });

                    config.DeleteAll<NCStatusRole>("NCStatusRole");
                    config.Insert(new NCStatusRole() { Id = "1", NCStatusId = 1, UserRoleId = 1 });
                    config.Insert(new NCStatusRole() { Id = "2", NCStatusId = 2, UserRoleId = 3 });
                    config.Insert(new NCStatusRole() { Id = "3", NCStatusId = 3, UserRoleId = 1 });
                    config.Insert(new NCStatusRole() { Id = "4", NCStatusId = 3, UserRoleId = 2 });

                    config.DeleteAll<Category>("Category");
                    config.Insert(new Category() { Id = "0", Title = " ", ParentCategoryId = 0 });
                    config.Insert(new Category() { Id = "1", Title = "Terra Wall", ParentCategoryId = 0 });
                    config.Insert(new Category() { Id = "2", Title = "Structural Glazing", ParentCategoryId = 0 });
                    config.Insert(new Category() { Id = "3", Title = "Safety", ParentCategoryId = 0 });
                    config.Insert(new Category() { Id = "4", Title = "Damage/Impact to others work", ParentCategoryId = 1 });
                    config.Insert(new Category() { Id = "5", Title = "Face Stone not proper", ParentCategoryId = 1 });
                    config.Insert(new Category() { Id = "6", Title = "Safety Helmet Color Identity not Followed", ParentCategoryId = 3 });
                    config.Insert(new Category() { Id = "7", Title = "Safety net for height work", ParentCategoryId = 3 });

                    config.DeleteAll<Severity>("Severity");
                    config.Insert(new Severity() { Id = "1", Title = "Medium" });
                    config.Insert(new Severity() { Id = "2", Title = "Mild" });
                    config.Insert(new Severity() { Id = "3", Title = "Severe" });
                    config.Insert(new Severity() { Id = "4", Title = "Aesthetically Severe" });
                    config.Insert(new Severity() { Id = "5", Title = "Functional Severe" });

                    config.DeleteAll<RootCause>("RootCause");
                    config.Insert(new RootCause() { Id = "1", Title = "Did not supervise" });
                    config.Insert(new RootCause() { Id = "2", Title = "Allowed Bad material" });
                    config.Insert(new RootCause() { Id = "3", Title = "Lack of knowledge" });
                    config.Insert(new RootCause() { Id = "4", Title = "Improper supporting system" });
                    config.Insert(new RootCause() { Id = "5", Title = "Checklist not implemented" });

                    config.DeleteAll<StructuralMember>("StructuralMember");
                    config.Insert(new StructuralMember() { Id = "1", Title = "Tie beam" });
                    config.Insert(new StructuralMember() { Id = "2", Title = "Starecase" });
                    config.Insert(new StructuralMember() { Id = "3", Title = "Stub Column" });
                    config.Insert(new StructuralMember() { Id = "4", Title = "Column" });

                    config.DeleteAll<UnitType>("UnitType");
                    config.Insert(new UnitType() { Id = "1", Title = "Shop", ParentUnitTypeId = 0 });
                    config.Insert(new UnitType() { Id = "2", Title = "Flate", ParentUnitTypeId = 0 });
                    config.Insert(new UnitType() { Id = "3", Title = "Office", ParentUnitTypeId = 0 });
                    config.Insert(new UnitType() { Id = "4", Title = "Parking", ParentUnitTypeId = 0 });
                    config.Insert(new UnitType() { Id = "5", Title = "2 BHK", ParentUnitTypeId = 2 });
                    config.Insert(new UnitType() { Id = "6", Title = "3 BHK", ParentUnitTypeId = 2 });
                    config.Insert(new UnitType() { Id = "7", Title = "Entrance Lobby", ParentUnitTypeId = 0 });

                    config.DeleteAll<UnitTypeRoom>("UnitTypeRoom");
                    config.Insert(new UnitTypeRoom() { Id = "1", UnitTypeId = 5, RoomTypeId = 1 });
                    config.Insert(new UnitTypeRoom() { Id = "2", UnitTypeId = 5, RoomTypeId = 2 });
                    config.Insert(new UnitTypeRoom() { Id = "3", UnitTypeId = 3, RoomTypeId = 5 });
                    config.Insert(new UnitTypeRoom() { Id = "4", UnitTypeId = 7, RoomTypeId = 5 });

                    config.DeleteAll<Building>("Building");
                    config.Insert(new Building() { Id = "1", Title = "B-Building", ProjectId = 1 });
                    config.Insert(new Building() { Id = "2", Title = "A-Building", ProjectId = 1 });
                    config.Insert(new Building() { Id = "3", Title = "Parijat", ProjectId = 2 });
                    config.Insert(new Building() { Id = "4", Title = "Gulmohar", ProjectId = 2 });

                    config.DeleteAll<BuildingFloor>("BuildingFloor");
                    config.Insert(new BuildingFloor() { Id = "1", BuildingId = 1, FloorId = 1 });
                    config.Insert(new BuildingFloor() { Id = "2", BuildingId = 1, FloorId = 2 });
                    config.Insert(new BuildingFloor() { Id = "3", BuildingId = 1, FloorId = 3 });
                    config.Insert(new BuildingFloor() { Id = "4", BuildingId = 2, FloorId = 1 });
                    config.Insert(new BuildingFloor() { Id = "5", BuildingId = 2, FloorId = 2 });

                    config.DeleteAll<BuildingUnit>("BuildingUnit");
                    config.Insert(new BuildingUnit() { Id = "1", BuildingFloorId = 1, Title = "B01", UnitTypeId = 6 });
                    config.Insert(new BuildingUnit() { Id = "2", BuildingFloorId = 1, Title = "B02", UnitTypeId = 5 });
                    config.Insert(new BuildingUnit() { Id = "3", BuildingFloorId = 1, Title = "B03", UnitTypeId = 5 });
                    config.Insert(new BuildingUnit() { Id = "4", BuildingFloorId = 2, Title = "A01", UnitTypeId = 6 });
                    config.Insert(new BuildingUnit() { Id = "5", BuildingFloorId = 2, Title = "A02", UnitTypeId = 5 });
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }

        }

        private async void btnlogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeraProjects_Page());
        }
    }
}