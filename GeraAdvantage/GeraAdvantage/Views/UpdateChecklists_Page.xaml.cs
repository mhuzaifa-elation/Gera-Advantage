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
    public partial class UpdateChecklists_Page : ContentPage
    {
        private List<Checklist> _checklist;

        private List<Checklist> CheckList
        {
            get => _checklist;
            set
            {
                if (value == _checklist)
                {
                    return;
                }
                _checklist = value;
                OnPropertyChanged(nameof(CheckList));
            }
        }
        public UpdateChecklists_Page()
        {
            BindingContext = this;
            InitializeComponent();
            DummyDataInitialization();
            listView.ItemsSource = CheckList;
        }

        private void DummyDataInitialization()
        {
            CheckList = new List<Checklist>();
            CheckList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Pending });
            CheckList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Approved });
            CheckList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Sent_To_QA });
            CheckList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Pending_For_NC_Closure });
        }

        void OnImageTapped(object sender, EventArgs args)
        {
            var image = sender as Image;
            var viewCell = image.Parent.Parent as ViewCell;

            if (image.HeightRequest < 250)
            {
                image.HeightRequest = image.Height + 100;
                viewCell.ForceUpdateSize();
            }
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           // Navigation.PushAsync(Navigation);
        }
    }
}
