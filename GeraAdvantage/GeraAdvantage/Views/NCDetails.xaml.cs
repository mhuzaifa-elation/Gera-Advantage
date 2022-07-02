using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GeraAdvantage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NCDetails : ContentPage
    {
        private string _sampleText;

        public string SampleText
        {
            get => _sampleText;
            set
            {
                if (value == _sampleText)
                {
                    return;
                }
                _sampleText = value;
                OnPropertyChanged(nameof(SampleText));
            }
        }
        public NCDetails()
        {
            BindingContext = this;
            InitializeComponent();
            SampleText = "This is Sample Text.";
        }

        private async void ShowHistory_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowNCHistory());
        }
        private async void AddPhoto_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new UploadImageDialoge());
        }

        private async void EditNCDetails_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditNCDetails());
        }
        private async void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            List<string> StatusArray = new List<string>() { "Approved", "Open", "Not Approved", "Not possible to close", "Work done by contractor" };
            string Result = await DisplayActionSheet("Select Status",null, null, StatusArray.ToArray());
            if (Result != null)
            {
                SampleText = Result;
            }
        }
    }
}