using System;
using System.Collections;
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
    public partial class NCList : ContentPage
    {
        private  List<Checklist> _checkList;

        public NCList()
        {
            BindingContext = this;
            InitializeComponent();
            DummyDataInitialization();
            listView.ItemsSource = _checkList;
        }

        private void DummyDataInitialization()
        {
            _checkList = new List<Checklist>();
            _checkList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Pending, ProjDate = DateTime.Now.ToString(), Deadline = DateTime.Today.AddDays(-2).ToShortDateString() });
            _checkList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Approved, ProjDate = DateTime.Now.ToString(), Deadline = DateTime.Today.AddDays(8).ToShortDateString() });
            _checkList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Approved, ProjDate = DateTime.Now.ToString(), Deadline = DateTime.Today.AddDays(4).ToShortDateString() });
            _checkList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Approved, ProjDate = DateTime.Now.ToString(), Deadline = DateTime.Today.AddDays(2).ToShortDateString() });
            _checkList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Approved, ProjDate = DateTime.Now.ToString(), Deadline = DateTime.Today.AddDays(3).ToShortDateString() });
            _checkList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Approved, ProjDate = DateTime.Now.ToString(), Deadline = DateTime.Today.AddDays(-2).ToShortDateString() });
            _checkList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Sent_To_QA, ProjDate = DateTime.Now.ToString(), Deadline = DateTime.Today.AddDays(2).ToShortDateString() });
            _checkList.Add(new Checklist { Title = "Mocca", Building = "B-Bld -as - 0.1", Floor = "BG02 | Ground", Category = "A/C Installation", CreatedBy = "Test User 27/06/2022", UpdatedBy = "Test User 28/06/2022", Cstatus = Status.Pending_For_NC_Closure, ProjDate = DateTime.Now.ToString(), Deadline = DateTime.Today.AddDays(-5).ToShortDateString() });
            foreach (var item in _checkList)
            {
                item.IsPast = Convert.ToDateTime(item.Deadline) < DateTime.Today;
            }
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

    }
}