using GeraAdvantage.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GeraAdvantage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectDetails_Page : ContentPage
    {
        public ProjectDetails_Page()
        {
            InitializeComponent();
        }
        private async void StakeHolders_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StakeHoldersList());
        }
        private async void PotentialNCManagement_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NCList());
        }
        private async void NCList_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NonConformityFiltersTemplate());
        }
        private async void ConformityDashboard_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConformityDashboard());
        }
        private async void NCDashboard_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NCDashboard());
        }
        private async void BtnCreateNC_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateNC());
        }
        private async void NCManagement_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NCManagement());
        }
        private async void BtnChecklist_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Checklists_Page());
        }
        private async void BtnSnaglist_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateSnaglist());
        }
        private async void ProjectDashboard_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectDashboard());
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("asd", "asd", "asd");
        }
    }
}