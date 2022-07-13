using Rg.Plugins.Popup.Pages;
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
    public partial class SearchDialoge
    {
        private List<FilterDetail> SampleList;
        public SearchDialoge()
        {
            BindingContext = this;
            InitializeComponent();
            DummyDataInitialization();
            listView.ItemsSource = SampleList;
        }

        private void DummyDataInitialization()
        {
            SampleList = new List<FilterDetail>();
            for (int i = 1; i <= 15; i++)
            {
                SampleList.Add(new FilterDetail() { Title = "Option " + i });
            }
            
        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await  PopupNavigation.Instance.PopAsync();
        }
    }
}