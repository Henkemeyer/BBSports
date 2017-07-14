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
    public partial class NewPerform : ContentPage
    {
        public NewPerform()
        {
            InitializeComponent();
        }

        async void Continue_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StopWatch());
        }
    }
}