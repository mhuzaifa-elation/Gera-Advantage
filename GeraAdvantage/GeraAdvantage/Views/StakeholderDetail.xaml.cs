using Plugin.Messaging;
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
    public partial class StakeholderDetail : ContentPage
    {        public StakeholderDetail()
        {
            InitializeComponent();
        }
        private void Phone_Clicked(object sender, EventArgs e) => CrossMessaging.Current.PhoneDialer.MakePhoneCall(lblPhone.Text);
        private void Mail_Clicked(object sender, EventArgs e) => Device.OpenUri(new Uri($"mailto:{lblMail.Text}"));
    }
}