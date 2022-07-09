using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static GeraAdvantage.Utils.Entities;

namespace GeraAdvantage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewCheckList : ContentPage,INotifyPropertyChanged, INotifyCollectionChanged
    {
        private List<MultileOps> List;

        private List<MultileOps> _opsList
        {
            get => List;
            set
            {
                if (value == List)
                {
                    return;
                }
                List = value;
                OnPropertyChanged(nameof(_opsList));
            }
        }
        MultileOps SeletedItem;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public ViewCheckList()
        {
            BindingContext = this;
            InitializeComponent();
            InitializeDummyData();
            listView.ItemsSource = _opsList;
            LCount.Text = _opsList.Count.ToString();
        }
        private void InitializeDummyData()
        {
            _opsList = new List<MultileOps>();
            _opsList.Add(new MultileOps() { Title = "1- This is sample", isfour = false, isthree = true, ConverttoNC = false , SEComment = false , AddImage = false });
            _opsList.Add(new MultileOps() { Title = "2- This is sample", isfour = true, isthree = false, ConverttoNC = false, SEComment = false, AddImage = false });
            _opsList.Add(new MultileOps() { Title = "3- This is sample", isfour = false, isthree = true, ConverttoNC = false, SEComment = false, AddImage = false });
            _opsList.Add(new MultileOps() { Title = "4- This is sample", isfour = true, isthree = false, ConverttoNC = false, SEComment = false, AddImage = false });
            _opsList.Add(new MultileOps() { Title = "5- This is sample", isfour = false, isthree = true, ConverttoNC = false, SEComment = false, AddImage = false });
            _opsList.Add(new MultileOps() { Title = "6- This is sample", isfour = true, isthree = false, ConverttoNC = false, SEComment = false, AddImage = false });
        }
        private async void BtnOK_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReviewQuestion());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var Btn = (Button)sender;
            Btn.BorderColor = Color.DodgerBlue;
            if (SeletedItem==null)
                return;
                
            switch (Btn.Text)
            {

                case "AWC":
                   _opsList[_opsList.IndexOf(SeletedItem)].ConverttoNC = false;
                   _opsList[_opsList.IndexOf(SeletedItem)].SEComment = true;
                   _opsList[_opsList.IndexOf(SeletedItem)].AddImage = false;
                    break;
                case "R":
                   _opsList[_opsList.IndexOf(SeletedItem)].ConverttoNC = true;
                   _opsList[_opsList.IndexOf(SeletedItem)].SEComment = false;
                   _opsList[_opsList.IndexOf(SeletedItem)].AddImage = false;
                    break;
                 default:
                    _opsList[_opsList.IndexOf(SeletedItem)].ConverttoNC = false;
                    _opsList[_opsList.IndexOf(SeletedItem)].SEComment = false;
                    _opsList[_opsList.IndexOf(SeletedItem)].AddImage = false;
                    break;




            }
            listView.ItemsSource = null;
            listView.ItemsSource = _opsList;
        }
        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            SeletedItem = (MultileOps)e.Item;
        }
    }


}