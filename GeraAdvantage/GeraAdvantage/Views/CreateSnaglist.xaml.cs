using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static GeraAdvantage.Utils.Entities;

namespace GeraAdvantage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateSnaglist : ContentPage
    {

        private string _sampleText;
        public string SamplePick
        {
            get => _sampleText;
            set
            {
                if (value == _sampleText)
                {
                    return;
                }
                _sampleText = value;
                OnPropertyChanged(nameof(SamplePick));
            }
        }

        public CreateSnaglist()
        {
            InitializeComponent();
            BindingContext = this;
        }
        private async void BtnView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewSnaglist());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            SamplePick = "";
            await PopupNavigation.Instance.PushAsync(new SearchMultipleDialoge());
            MessagingCenter.Subscribe<List<FilterDetail>>(this, "SelectedOption",
                                (value) =>
                                {
                                    if (value.Count>0)
                                    {
                                        foreach (var item in value)
                                        {
                                            SamplePick += item.Title + ", ";
                                        }
                                        SamplePick = SamplePick.Substring(0, SamplePick.Length - 2);
                                    }
                                    else
                                    {
                                        SamplePick = "";
                                    }
                                    MessagingCenter.Unsubscribe<List<FilterDetail>>(this, "SelectedOption");
                                });
        }
    }
}