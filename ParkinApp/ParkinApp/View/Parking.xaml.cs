using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ParkinApp.ViewModel;

namespace ParkinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Parking : ContentPage
	{
		public Parking ()
		{
			InitializeComponent ();
            ParkingLotViewModel x = new ParkingLotViewModel();
            this.BindingContext = x;
        }
	}
}