﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GeraAdvantage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Checklists_Page : ContentPage
    {
        public Checklists_Page(string checklistType)
        {
            InitializeComponent();
            InitializeTitles(checklistType);
        }

        private void InitializeTitles(string checklistType)
        {
            Title = checklistType;
            LblCreate.Text = "Create " + checklistType;
            LblUpdate.Text = "Update " + checklistType;
           LblIncomplete.Text = "Incomlete " + checklistType;

        }

        private async void BtnUpdateChecklist_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpdateChecklists_Page());
        }
        private async void BtnCreateChecklist_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateChecklist_Page());
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("asd", "asd", "asd");
        }
    }
}