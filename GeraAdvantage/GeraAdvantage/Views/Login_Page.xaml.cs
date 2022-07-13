using GeraAdvantage.Views;
using Rg.Plugins.Popup.Services;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static GeraAdvantage.Utils.Entities;

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
            
        }
        private async void btnlogin_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new GeraProjects_Page());
        }
    }
}