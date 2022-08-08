﻿using GeraAdvantage.SQLServices;
using GeraAdvantage.Utils;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GeraAdvantage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateChecklist_Page : ContentPage, INotifyPropertyChanged
    {
        private string  _sampleText;

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

        public CreateChecklist_Page()
        {
            InitializeComponent();
            BindingContext = this;
           
        }
        private async void BtnView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewCheckList());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            SQLConfig Config = new SQLConfig();
            var List = Config.GetItems<Building>().ToList();
            await PopupNavigation.Instance.PushAsync(new SearchDialoge(List.Select(x => x.Title).ToList()));
            MessagingCenter.Subscribe<string>(this, "SelectedOption",
                                (value) =>
                                {
                                    if (value.Length > 0)
                                    {
                                        var Option = List.FirstOrDefault(x => x.Title == value);
                                        SamplePick = Option.Title;
                                        MessagingCenter.Unsubscribe<string>(this, "SelectedOption");
                                    }
                                });
        }
    }
}