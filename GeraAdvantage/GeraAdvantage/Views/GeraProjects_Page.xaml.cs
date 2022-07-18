using GeraAdvantage.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static GeraAdvantage.Utils.Entities;

namespace GeraAdvantage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeraProjects_Page : ContentPage
    {
        private List<Project> projectsList;
        public GeraProjects_Page()
        {
            InitializeComponent();
            DummyDataInitialization();
            DefineGridLayout();
        }

        private void DummyDataInitialization()
        {
            projectsList = new List<Project>();
            projectsList.Add(new Project { Title = "Mocca", TotalNCCount = 12, OpenNCCount = 1 });
            projectsList.Add(new Project { Title = "Espresso", TotalNCCount = 6, OpenNCCount = 43 });
            projectsList.Add(new Project { Title = "Latte", TotalNCCount = 2, OpenNCCount = 5 });
            //projectsList.Add(new Project { Title = "Americano", TotalNCCount = 12, OpenNCCount = 1 });
            //projectsList.Add(new Project { Title = "Arabica", TotalNCCount = 9, OpenNCCount = 4 });
        }

        private void DefineGridLayout()
        {

            var rowlimit = projectsList.Count / 2 + (projectsList.Count % 2 == 0 ? 0 : 1);

            var productIndex = 0;
            for (int rowIndex = 0; rowIndex < rowlimit; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < 2; columnIndex++)
                {
                    if (productIndex >= projectsList.Count)
                    {
                        break;
                    }
                    var product = projectsList[productIndex];
                    productIndex += 1;
                    var GridCellLayout = new StackLayout
                    {
                        Style = (Style)Application.Current.Resources["ProjectCellLayout"]
                    };
                    var frame = new StackLayout
                    {
                        Style = (Style)Application.Current.Resources["ProjectframeLayout"]
                    };
                    var image = new Image
                    {
                        Source = "noimage.png",
                        Style = (Style)Application.Current.Resources["ProjectImage"]

                    };
                    var innerlayout = new StackLayout
                    {
                        Style = (Style)Application.Current.Resources["ProjectInnerLayout"]
                    };
                    var Titlelabel = new Label
                    {
                        Text = product.Title,
                        Style = (Style)Application.Current.Resources["ProjectLabel"]
                    };
                    var TotalNClabel = new Label
                    {
                        Text = "Total NCs: " + product.TotalNCCount.ToString(),
                        Style = (Style)Application.Current.Resources["ProjectLabel"]

                    };
                    var OpenNClabel = new Label
                    {
                        Text = "Open NCs: " + product.OpenNCCount.ToString(),
                        Style = (Style)Application.Current.Resources["ProjectLabel"]

                    };
                    innerlayout.Children.Add(Titlelabel);
                    innerlayout.Children.Add(TotalNClabel);
                    innerlayout.Children.Add(OpenNClabel);
                    frame.Children.Add(image);
                    GridCellLayout.Children.Add(frame);
                    GridCellLayout.Children.Add(innerlayout);

                    var tapGestureRecognizer = new TapGestureRecognizer();
                    tapGestureRecognizer.Tapped += async (s, e) =>
                    {
                        int nRow = Grid.GetRow((BindableObject)s);
                        int nCol = Grid.GetColumn((BindableObject)s);

                        int projID = 2 * nRow + nCol;
                        await DisplayAlert("Title", projectsList[projID].Title, "OK");
                        await Navigation.PushAsync(new ProjectDetails_Page());
                    };
                    GridCellLayout.GestureRecognizers.Add(tapGestureRecognizer);
                    projectsGLayout.Children.Add(GridCellLayout, columnIndex, rowIndex);
                }
            }
        }

        private async void MyProfile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StakeholderDetail("My Profile", true));
        }
    }
}