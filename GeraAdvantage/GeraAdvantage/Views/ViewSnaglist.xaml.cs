using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class ViewSnaglist : ContentPage, INotifyPropertyChanged, INotifyCollectionChanged
    {
        ObservableCollection<Grouping<MultileOps, PlaceType>> List;
        private List<PlaceType> Places;

        private ObservableCollection<Grouping<MultileOps, PlaceType>> OpsList
        {
            get => List;
            set
            {
                if (value == List)
                {
                    return;
                }
                List = value;
                OnPropertyChanged(nameof(OpsList));
            }
        }
        MultileOps SeletedItem;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public ViewSnaglist()
        {
            BindingContext = this;
            InitializeComponent();
            InitializeDummyData();
            listView.ItemsSource = OpsList;
            LCount.Text = OpsList.Count.ToString();
        }
        private void InitializeDummyData()
        {
            Places = new List<PlaceType>() ;
            Places.Add(new PlaceType() { Title = "Master Bedroom", IsChecked = false });
            Places.Add(new PlaceType() { Title = "Guest Bedroom", IsChecked = false });
            Places.Add(new PlaceType() { Title = "Kitchen", IsChecked = false });
            Places.Add(new PlaceType() { Title = "Hall", IsChecked = false });

            OpsList = new ObservableCollection<Grouping<MultileOps, PlaceType>>();
            OpsList.Add(new Grouping<MultileOps, PlaceType>(new MultileOps() { Title = "1- This is sample", isfour = false, isthree = true, ConverttoNC = false, SEComment = false, AddImage = false, btnYes = false, btnNo = false, btnNA = false, btnA = false, btnAWC = false, btnR = false, Places= Places },Places));
            OpsList.Add(new Grouping<MultileOps, PlaceType>(new MultileOps() { Title = "2- This is sample", isfour = true, isthree = false, ConverttoNC = false, SEComment = false, AddImage = false, btnYes = false, btnNo = false, btnNA = false, btnA = false, btnAWC = false, btnR = false, Places = Places }, Places));
            OpsList.Add(new Grouping<MultileOps, PlaceType>(new MultileOps() { Title = "3- This is sample", isfour = false, isthree = true, ConverttoNC = false, SEComment = false, AddImage = false, btnYes = false, btnNo = false, btnNA = false, btnA = false, btnAWC = false, btnR = false, Places = Places }, Places));
            OpsList.Add(new Grouping<MultileOps, PlaceType>(new MultileOps() { Title = "4- This is sample", isfour = true, isthree = false, ConverttoNC = false, SEComment = false, AddImage = false, btnYes = false, btnNo = false, btnNA = false, btnA = false, btnAWC = false, btnR = false, Places = Places }, Places));
            OpsList.Add(new Grouping<MultileOps, PlaceType>(new MultileOps() { Title = "5- This is sample", isfour = false, isthree = true, ConverttoNC = false, SEComment = false, AddImage = false, btnYes = false, btnNo = false, btnNA = false, btnA = false, btnAWC = false, btnR = false, Places = Places }, Places));
            OpsList.Add(new Grouping<MultileOps, PlaceType>(new MultileOps() { Title = "6- This is sample", isfour = true, isthree = false, ConverttoNC = false, SEComment = false, AddImage = false, btnYes = false, btnNo = false, btnNA = false, btnA = false, btnAWC = false, btnR = false, Places = Places }, Places));
            OpsList.Add(new Grouping<MultileOps, PlaceType>(new MultileOps() { Title = "7- This is sample", isfour = false, isthree = true, ConverttoNC = false, SEComment = false, AddImage = false, btnYes = false, btnNo = false, btnNA = false, btnA = false, btnAWC = false, btnR = false, Places = Places }, Places));
        }
        private async void BtnOK_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReviewQuestion());
        }
        private void PictureButton_Clicked(object sender, EventArgs e)
        {

            var frame = new StackLayout
            {
                Style = (Style)Application.Current.Resources["ProjectframeLayout"]
            };
            var image = new Image
            {
                Source = "noimage.png",
                Style = (Style)Application.Current.Resources["ProjectImage"]

            };

        }
        private void Button_Clicked(object sender, EventArgs e)
        {




            var button = (Button)sender;
            var item = (Grouping<MultileOps, PlaceType>)button.BindingContext;
            var index = OpsList.IndexOf(item);

            switch (button.Text)
            {
                case "Yes":
                    OpsList[index].Key.ConverttoNC = false;
                    OpsList[index].Key.SEComment = false;
                    OpsList[index].Key.AddImage = false;

                    OpsList[index].Key.btnAWC = false;
                    OpsList[index].Key.btnA = false;
                    OpsList[index].Key.btnNA = false;
                    OpsList[index].Key.btnNo = false;
                    OpsList[index].Key.btnR = false;
                    OpsList[index].Key.btnYes = true;
                    break;
                case "No":
                    OpsList[index].Key.ConverttoNC = false;
                    OpsList[index].Key.SEComment = false;
                    OpsList[index].Key.AddImage = false;

                    OpsList[index].Key.btnAWC = false;
                    OpsList[index].Key.btnA = false;
                    OpsList[index].Key.btnNA = false;
                    OpsList[index].Key.btnNo = true;
                    OpsList[index].Key.btnR = false;
                    OpsList[index].Key.btnYes = false;
                    break;
                case "NA":
                    OpsList[index].Key.ConverttoNC = false;
                    OpsList[index].Key.SEComment = false;
                    OpsList[index].Key.AddImage = false;

                    OpsList[index].Key.btnAWC = false;
                    OpsList[index].Key.btnA = false;
                    OpsList[index].Key.btnNA = true;
                    OpsList[index].Key.btnNo = false;
                    OpsList[index].Key.btnR = false;
                    OpsList[index].Key.btnYes = false;
                    break;
                case "A":
                    OpsList[index].Key.ConverttoNC = false;
                    OpsList[index].Key.SEComment = false;
                    OpsList[index].Key.AddImage = false;

                    OpsList[index].Key.btnAWC = false;
                    OpsList[index].Key.btnA = true;
                    OpsList[index].Key.btnNA = false;
                    OpsList[index].Key.btnNo = false;
                    OpsList[index].Key.btnR = false;
                    OpsList[index].Key.btnYes = false;
                    break;
                case "AWC":
                    OpsList[index].Key.ConverttoNC = false;
                    OpsList[index].Key.SEComment = true;
                    OpsList[index].Key.AddImage = false;


                    OpsList[index].Key.btnAWC = true;
                    OpsList[index].Key.btnA = false;
                    OpsList[index].Key.btnNA = false;
                    OpsList[index].Key.btnNo = false;
                    OpsList[index].Key.btnR = false;
                    OpsList[index].Key.btnYes = false;

                    break;
                case "R":
                    OpsList[index].Key.ConverttoNC = true;
                    OpsList[index].Key.SEComment = false;
                    OpsList[index].Key.AddImage = false;

                    OpsList[index].Key.btnAWC = false;
                    OpsList[index].Key.btnA = false;
                    OpsList[index].Key.btnNA = false;
                    OpsList[index].Key.btnNo = false;
                    OpsList[index].Key.btnR = true;
                    OpsList[index].Key.btnYes = false;
                    break;
                default:
                    OpsList[index].Key.ConverttoNC = false;
                    OpsList[index].Key.SEComment = false;
                    OpsList[index].Key.AddImage = false;


                    break;


            }
            listView.ItemsSource = null;
            listView.ItemsSource = OpsList;
        }
        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            SeletedItem = (MultileOps)e.Item;
        }
    }


}