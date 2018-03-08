using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HamburgerMenu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HamburgerMenu : MasterDetailPage
	{
        public static int idiom;
        string idiomassss = "";
        MultiLanguajeClass idi = new MultiLanguajeClass(idiom);
        char Chardelimiter;
        String[] Lang; //Arreglo del lenguaje
        public HamburgerMenu ()
		{
			InitializeComponent ();
            MyMenu();

        }
        public void MyMenu()
        {
            idiomassss = idi.Languaje();
            Chardelimiter = ',';
            Lang = idiomassss.Split(Chardelimiter);
            Detail = new NavigationPage(new Feed());
            List<Menu> menu = new List<Menu>
            {
                 new Menu{ Page= new Feed(),MenuTitle=Lang[0],  MenuDetail=Lang[1],icon="user.png"},
                new Menu{ Page= new Feed(),MenuTitle=Lang[2],  MenuDetail=Lang[3],icon="message.png"},
                new Menu{ Page= new Feed(),MenuTitle=Lang[4],  MenuDetail=Lang[5],icon="contacts.png"},
                new Menu{ Page= new Feed(),MenuTitle=Lang[6],  MenuDetail=Lang[7],icon="settings.png"},
                new Menu{ Page= new Feed(),MenuTitle=Lang[8],  MenuDetail=Lang[9],icon="settings.png"},
                new Menu{ Page= new Feed(),MenuTitle=Lang[10],  MenuDetail="",icon="settings.png"},
            };
            ListMenu.ItemsSource = menu;
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
            }
        }
        public class Menu
        {
            public string MenuTitle
            {
                get;
                set;
            }
            public string MenuDetail
            {
                get;
                set;
            }

            public ImageSource icon
            {
                get;
                set;
            }

            public Page Page
            {
                get;
                set;
            }
        }
	}
}