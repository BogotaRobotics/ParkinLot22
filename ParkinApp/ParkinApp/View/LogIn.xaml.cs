using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogIn : ContentPage
	{
        public double ScreenWidth { get; set; }
        public double ScreenHeight { get; set; }
        public LogIn ()
		{
            ScreenWidth = Application.Current.MainPage.Width/3;
            ScreenHeight = Application.Current.MainPage.Height/3;
			InitializeComponent ();
		}
	}
}