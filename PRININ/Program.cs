using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using PRININ.Classes;

namespace PRININ
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //BonusSkins.Register();

            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Whiteprint");
            //Application.Run(new frmMenuPrinin());// Form1());

            var login = new LoginPrinin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Users vUserLogin = login.UsuarioLogueado;
                frmMenuPrinin form = new frmMenuPrinin(login.UsuarioLogueado, login.UsuarioLogueado.theme);
                form.UsuarioLogueado = login.UsuarioLogueado;
                Application.Run(form);
            }



            //Application.Run(new TEMP_JV());
            //Application.Run(new ND_NC_OptionsPrint());

        }
    }
}
