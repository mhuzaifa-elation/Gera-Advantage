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
    public partial class ViewCheckList : ContentPage
    {
        public ViewCheckList()
        {
            List<MultileOps> _opsList = new List<MultileOps>() { new MultileOps() { Title = "Hello", isfour = false, isthree = true } };
            InitializeComponent();
           listView.ItemsSource= _opsList;
        }
    }

    internal class MultileOps
    {
        public MultileOps()
        {
        }

        public string Title { get; set; }
        public bool isfour { get; set; }
        public bool isthree { get; set; }
    }
}