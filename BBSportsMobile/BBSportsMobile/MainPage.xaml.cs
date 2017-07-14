using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BBSportsMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void LoginButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navigation());
        }
    }
}
