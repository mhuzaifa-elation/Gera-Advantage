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
        string paramtr;
        private List<FilterDetail> SampleList;
        public SearchDialoge(string parameter)
        {
            BindingContext = this;
            InitializeComponent();
            this.paramtr = parameter;
            DummyDataInitialization(parameter);

            listView.ItemsSource = SampleList;
        }

        private void DummyDataInitialization(string paramter)
        {
            if(paramter== "Building")
            {
                SampleList = new List<FilterDetail>();
                for (int i = 1; i <= 15; i++)
                {
                    SampleList.Add(new FilterDetail() { Title = "Buliding " + i });
                }
            }
           else if (paramter == "Floor")
            {
                SampleList = new List<FilterDetail>();
                for (int i = 1; i <= 15; i++)
                {
                    SampleList.Add(new FilterDetail() { Title = "Floor " + i });
                }
            }
           else if (paramter == "Flat")
            {
                SampleList = new List<FilterDetail>();
                for (int i = 1; i <= 15; i++)
                {
                    SampleList.Add(new FilterDetail() { Title = "Flat " + i });
                }
            }
           else if (paramter == "Side")
            {
                SampleList = new List<FilterDetail>();
                for (int i = 1; i <= 15; i++)
                {
                    SampleList.Add(new FilterDetail() { Title = "Side " + i });
                }
            }
           else if (paramter == "Room")
            {
                SampleList = new List<FilterDetail>();
                for (int i = 1; i <= 15; i++)
                {
                    SampleList.Add(new FilterDetail() { Title = "Room " + i });
                }
            }
            else if (paramter == "Category")
            {
                SampleList = new List<FilterDetail>();
                for (int i = 1; i <= 15; i++)
                {
                    SampleList.Add(new FilterDetail() { Title = "Category " + i });
                }
            }
           else if (paramter == "Contractor")
            {
                SampleList = new List<FilterDetail>();
                for (int i = 1; i <= 15; i++)
                {
                    SampleList.Add(new FilterDetail() { Title = "Contractor " + i });
                }
            }
           else if (paramter == "Resposible")
            {
                SampleList = new List<FilterDetail>();
                for (int i = 1; i <= 15; i++)
                {
                    SampleList.Add(new FilterDetail() { Title = "Resposible " + i });
                }
            }
            
        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var SelectedItem = (FilterDetail)e.Item;
            MessagingCenter.Send<string>(SelectedItem.Title, paramtr);
            await PopupNavigation.Instance.PopAsync();
        }

        private void Search_Clicked(object sender, EventArgs e)
        {
            if (EntSearch.Text.Length>0)
            {
                var SearchedList = SampleList.FindAll(x => x.Title.ToLower().Contains(EntSearch.Text.ToLower()));
                if (SearchedList.Count>0)
                {
                    listView.ItemsSource = null;
                    listView.ItemsSource = SearchedList;
                }
                else
                {
                    listView.ItemsSource = null;
                    listView.ItemsSource = SampleList;
                }
            }
            else
            {
                listView.ItemsSource = null;
                listView.ItemsSource = SampleList;
            }
        }
    }
}