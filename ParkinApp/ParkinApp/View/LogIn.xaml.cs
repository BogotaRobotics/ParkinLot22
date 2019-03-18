using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ParkinApp.View;


namespace ParkinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogIn : ContentPage
	{
		public LogIn ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent ();
		}

        private async void  Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Parking());
        }
    }
}