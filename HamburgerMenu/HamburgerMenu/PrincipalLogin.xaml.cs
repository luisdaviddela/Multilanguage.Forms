using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HamburgerMenu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalLogin : ContentPage
    {//Español 2
     //Inglés 1
        public static int numIdiomaIjo = 0;
        public PrincipalLogin ()
		{
			InitializeComponent ();
		}
        private void btnE(object s, EventArgs e)
        {
            numIdiomaIjo = 1;
            App.Current.Properties["idioma"] = numIdiomaIjo;
            Navigation.PushAsync(new HamburgerMenu());
        }
        private void btn(object s, EventArgs e)
        {
            numIdiomaIjo = 2;
            App.Current.Properties["idioma"] = numIdiomaIjo;
            Navigation.PushAsync(new HamburgerMenu());
        }
    }
}