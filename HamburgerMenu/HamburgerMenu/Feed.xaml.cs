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
	public partial class Feed : ContentPage
	{
        int IdiomaLo = 0;
        public Feed ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            if (Application.Current.Properties.ContainsKey("idioma"))
            {
                var val = Convert.ToInt32(Application.Current.Properties["idioma"]);
                IdiomaLo = val;
                if (IdiomaLo == 1)
                {
                    idiImage.Source = ImageSource.FromFile("us.png");
                }
                else
                {
                    idiImage.Source = ImageSource.FromFile("es.jpg");
                }
            }
        }
    }
}