using GeraAdvantage.Models;
using GeraAdvantage.SQLServices;
using GeraAdvantage.Utils;
using GeraAdvantage.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GeraAdvantage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NonConformity : ContentPage, INotifyPropertyChanged
    {
        public NC model;
        public char[] spearator = { ' ' };
        private string _sampleText;
        private string AvailableImage;

        public long SamplePickIndex, BuildingPickIndex, FloorPickIndex, FlatTypePickIndex, SidePickIndex,
                    RoomPickIndex, CategoryPickIndex, ContractorPickIndex, ResposiblePickIndex;
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
        private string _BuildingPick;

        public string BuildingPick
        {
            get => _BuildingPick;
            set
            {
                if (value == _BuildingPick)
                {
                    return;
                }
                _BuildingPick = value;
                OnPropertyChanged(nameof(BuildingPick));
            }
        }
        private string _FloorPick;

        public string FloorPick
        {
            get => _FloorPick;
            set
            {
                if (value == _FloorPick)
                {
                    return;
                }
                _FloorPick = value;
                OnPropertyChanged(nameof(FloorPick));
            }
        }
        private string _FlatTypePick;

        public string FlatTypePick
        {
            get => _FlatTypePick;
            set
            {
                if (value == _FlatTypePick)
                {
                    return;
                }
                _FlatTypePick = value;
                OnPropertyChanged(nameof(FlatTypePick));
            }
        }
        private string _SidePick;

        public string SidePick
        {
            get => _SidePick;
            set
            {
                if (value == _SidePick)
                {
                    return;
                }
                _SidePick = value;
                OnPropertyChanged(nameof(SidePick));
            }
        }
        private string _RoomPick;

        public string RoomPick
        {
            get => _RoomPick;
            set
            {
                if (value == _RoomPick)
                {
                    return;
                }
                _RoomPick = value;
                OnPropertyChanged(nameof(RoomPick));
            }
        }
        private string _CategoryPick;

        public string CategoryPick
        {
            get => _CategoryPick;
            set
            {
                if (value == _CategoryPick)
                {
                    return;
                }
                _CategoryPick = value;
                OnPropertyChanged(nameof(CategoryPick));
            }
        }
        private string _ContractorPick;

        public string ContractorPick
        {
            get => _ContractorPick;
            set
            {
                if (value == _ContractorPick)
                {
                    return;
                }
                _ContractorPick = value;
                OnPropertyChanged(nameof(ContractorPick));
            }
        }
        private string _ResposiblePick;

        public string ResponsiblePick
        {
            get => _ResposiblePick;
            set
            {
                if (value == _ResposiblePick)
                {
                    return;
                }
                _ResposiblePick = value;
                OnPropertyChanged(nameof(ResponsiblePick));
            }
        }


        public NonConformity()
        {
            InitializeComponent();
            model = new NC();
            BindingContext = this;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string parameter = "Building";
            await PopupNavigation.Instance.PushAsync(new SearchDialoge(parameter));
            MessagingCenter.Subscribe<string>(this, "SelectedOption",
                                        (value) =>
                                        {
                                            SamplePick = value;
                                            SamplePickIndex = Convert.ToInt64(SamplePick.Split(spearator)[1]);
                                            MessagingCenter.Unsubscribe<string>(this, "SelectedOption");
                                        });
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new UploadImageDialoge());
            MessagingCenter.Subscribe<FileResult>(this, "ImageDialoge",
                                                    async (value) =>
                                                    {
                                                        AvailableImage = UtilServices.ConvertImagetoBase64Text(value).Result ;
                                                        MessagingCenter.Unsubscribe<FileResult>(this, "ImageDialoge");
                                                        var Stream = await value.OpenReadAsync();
                                                        SelectedImage.Source = ImageSource.FromStream(() => Stream);
                                                    });
        }
        private async void Save_Clicked(object sender, EventArgs e)
        {
            model.BuildingId = SamplePickIndex;
            model.FloorId = FloorPickIndex;
            model.UnitTypeId = FlatTypePickIndex;
            model.UnitId = SidePickIndex;
            model.RoomTypeId = RoomPickIndex;
            model.CategoryId = CategoryPickIndex;
            model.ContractorId = ContractorPickIndex;
            model.EngineerId = ResposiblePickIndex;
            model.NCCode = "NC";
            model.IsPotential = IsPotentialChkBx.IsChecked;
            model.ProjectId = 0;
            model.SubCategoryId = 0;
            model.Image = AvailableImage;
            model.CorrectiveAction = CorrectiveActionEnt.Text;
            model.PrevenctiveAction = PreventiceActionEnt.Text;
            model.CreatedBy = "Test User";
            model.CreatedOn = DateTime.Now;
            model.UpdatedBy = "Test User";
            model.UpdatedOn = DateTime.Now;
            model.DeadlineDate= DateTime.Now.AddDays(10);

            NCServices ncServices = new NCServices();
            
            //bool res = DependencyService.Get<ISQLite>().SaveNCAndC(model);
            //bool res =true;
            if (ncServices.SaveNC(model))
            {
                await Application.Current.MainPage.DisplayAlert("Message", "Data Save Successfully", "Ok");
                ResetForm();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Message", "Data Failed To Save", "Ok");
            }
        }

        private void ResetForm()
        {
            BuildingPick = String.Empty;
            FloorPick = String.Empty;
            FlatTypePick = String.Empty;
            RoomPick = String.Empty;
            CategoryPick = String.Empty;
           ContractorPick  = String.Empty;
            ResponsiblePick = String.Empty;
            AvailableImage = String.Empty;
            SelectedImage.Source =null;
        }

        private async void Building_Clicked(object sender, EventArgs e)
        {
            string parameter = "Building";
            await PopupNavigation.Instance.PushAsync(new SearchDialoge(parameter));
            MessagingCenter.Subscribe<string>(this, "Building",
                                             (value) =>
                                             {
                                                 BuildingPick = value;
                                                 BuildingPickIndex = Convert.ToInt64(BuildingPick.Split(spearator)[1]);
                                                 MessagingCenter.Unsubscribe<string>(this, "Building");
                                             });

        }
        private async void Floor_Clicked(object sender, EventArgs e)
        {
            string parameter = "Floor";
            await PopupNavigation.Instance.PushAsync(new SearchDialoge(parameter));
            MessagingCenter.Subscribe<string>(this, "Floor",
                                             (value) =>
                                             {
                                                 FloorPick = value;
                                                 FloorPickIndex = Convert.ToInt64(FloorPick.Split(spearator)[1]);
                                                 MessagingCenter.Unsubscribe<string>(this, "Floor");
                                             });

        }
        private async void Flat_Clicked(object sender, EventArgs e)
        {
            string parameter = "Flat";
            await PopupNavigation.Instance.PushAsync(new SearchDialoge(parameter));
            MessagingCenter.Subscribe<string>(this, "Flat",
                                             (value) =>
                                             {
                                                 FlatTypePick = value;
                                                 FlatTypePickIndex = Convert.ToInt64(FlatTypePick.Split(spearator)[1]);
                                                 MessagingCenter.Unsubscribe<string>(this, "Flat");
                                             });

        }
        private async void Side_Clicked(object sender, EventArgs e)
        {
            string parameter = "Side";
            await PopupNavigation.Instance.PushAsync(new SearchDialoge(parameter));
            MessagingCenter.Subscribe<string>(this, "Side",
                                             (value) =>
                                             {
                                                 SidePick = value;
                                                 SidePickIndex = Convert.ToInt64(SidePick.Split(spearator)[1]);
                                                 MessagingCenter.Unsubscribe<string>(this, "Side");
                                             });

        }
        private async void Room_Clicked(object sender, EventArgs e)
        {
            string parameter = "Room";
            await PopupNavigation.Instance.PushAsync(new SearchDialoge(parameter));
            MessagingCenter.Subscribe<string>(this, "Room",
                                             (value) =>
                                             {
                                                 RoomPick = value;
                                                 RoomPickIndex = Convert.ToInt64(RoomPick.Split(spearator)[1]);
                                                 MessagingCenter.Unsubscribe<string>(this, "Room");
                                             });

        }
        private async void Category_Clicked(object sender, EventArgs e)
        {
            string parameter = "Category";
            await PopupNavigation.Instance.PushAsync(new SearchDialoge(parameter));
            MessagingCenter.Subscribe<string>(this, "Category",
                                             (value) =>
                                             {
                                                 CategoryPick = value;
                                                 CategoryPickIndex = Convert.ToInt64(CategoryPick.Split(spearator)[1]);
                                                 MessagingCenter.Unsubscribe<string>(this, "Category");
                                             });

        }
        private async void Contractor_Clicked(object sender, EventArgs e)
        {
            string parameter = "Contractor";
            await PopupNavigation.Instance.PushAsync(new SearchDialoge(parameter));
            MessagingCenter.Subscribe<string>(this, "Contractor",
                                             (value) =>
                                             {
                                                 ContractorPick = value;
                                                 ContractorPickIndex = Convert.ToInt64(ContractorPick.Split(spearator)[1]);
                                                 MessagingCenter.Unsubscribe<string>(this, "Contractor");
                                             });

        }
        private async void Resposible_Clicked(object sender, EventArgs e)
        {
            string parameter = "Resposible";
            await PopupNavigation.Instance.PushAsync(new SearchDialoge(parameter));
            MessagingCenter.Subscribe<string>(this, "Resposible",
                                             (value) =>
                                             {
                                                 ResponsiblePick = value;
                                                 ResposiblePickIndex = Convert.ToInt64(ResponsiblePick.Split(spearator)[1]);
                                                 MessagingCenter.Unsubscribe<string>(this, "Resposible");
                                             });

        }
    }
}