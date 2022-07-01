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
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("asd", "asd", "asd");
        }
    }
}