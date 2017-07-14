using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BBSportsMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navigation : ContentPage
    {
        public Navigation()
        {
            InitializeComponent();
        }

        async void MeetButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewMeet());
        }

        async void NewPerformButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPerform());
        }

        async void SwitchTeams_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwitchTeam());
        }
    }
}