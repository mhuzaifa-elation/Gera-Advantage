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
            projectsList.Add(new Project { Title = "Americano", TotalNCCount = 12, OpenNCCount = 1 });
            projectsList.Add(new Project { Title = "Arabica", TotalNCCount = 9, OpenNCCount = 4 });
            projectsList.Add(new Project { Title = "Arabica", TotalNCCount = 9, OpenNCCount = 4 });
            projectsList.Add(new Project { Title = "Arabica", TotalNCCount = 9, OpenNCCount = 4 });
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

                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Orientation = StackOrientation.Vertical,
                    };
                    var frame = new StackLayout
                    {
                        HeightRequest = 130,
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                    };

                    var innerlayout = new StackLayout
                    {
                        HeightRequest = 70,
                        Padding = new Thickness(0, 5, 0, 5),
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        BackgroundColor = Color.Gray
                    };
                    var Titlelabel = new Label
                    {
                        Text = product.Title,
                        TextColor = Color.White,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        BackgroundColor = Color.Gray
                    };
                    var TotalNClabel = new Label
                    {
                        Text = product.TotalNCCount.ToString(),
                        TextColor = Color.White,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        BackgroundColor = Color.Gray
                    };
                    var OpenNClabel = new Label
                    {
                        Text = product.OpenNCCount.ToString(),
                        TextColor = Color.White,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        BackgroundColor = Color.Gray
                    };
                    innerlayout.Children.Add(Titlelabel);
                    innerlayout.Children.Add(TotalNClabel);
                    innerlayout.Children.Add(OpenNClabel);
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
    }
}