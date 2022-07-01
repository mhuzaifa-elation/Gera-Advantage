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
    public partial class NCManagement : ContentPage
    {
        public NCManagement()
        {
            InitializeComponent();
        }

        private async void NonConformity_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NonConformityFiltersTemplate());
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
        }
    }
}