using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace HamburgerMenu
{
    class MultiLanguajeClass
    {
        public static int IdiomaLo = 0;
        public MultiLanguajeClass(int num)
        {
            if (Application.Current.Properties.ContainsKey("idioma"))
            {
                var val = Convert.ToInt32(Application.Current.Properties["idioma"]);
                IdiomaLo = val;
            }
        }
        public string Languaje()
        {
            //Inglés  = 1
            //Español = 2
            string vocabulary = "";

            switch (IdiomaLo)
            {

                case 1:
                    vocabulary = "User, My profile," +
                        "Feed, Feed," +
                        "Photo, Update profile photo," +
                        "Password, Update my password," +
                        "Token, View my current Token," +
                        "Log out";
                    break;
                case 2:
                    vocabulary = "Perfil, Ver mi perfil," +
                       "Inicio, ver noticias," +
                       "Foto, Actualizar foto de perfil," +
                       "Contraseña, Actualizar Contraseña," +
                       "Token, Ver mi token actual," +
                       "Cerrar sesión";
                    break;
            }
            return vocabulary;
        }
    }
}
