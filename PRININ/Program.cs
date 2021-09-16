using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using PRININ.Classes;
using DevExpress.Xpf.Core;
using DevExpress.XtraGauges.Presets.Styles;

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


            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Moderno");


            //protected override void OnStartup(StartupEventArgs e)
            //{
            //ApplicationThemeHelper.ApplicationThemeName = Theme.Military.Name;
            //base.OnStartup(e);
            //}

            //Application.Run(new frmMenuPrinin());// Form1());

            var login = new LoginPrinin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Users vUserLogin = login.UsuarioLogueado;
                MDIParentPRININ mdi = new MDIParentPRININ(login.UsuarioLogueado);
                mdi.WindowState = FormWindowState.Maximized;
                mdi.Show();

                //frmMenuPrinin form = new frmMenuPrinin(login.UsuarioLogueado, login.UsuarioLogueado.theme);
                //form.MdiParent = mdi;
                //form.UsuarioLogueado = login.UsuarioLogueado;
                Application.Run(mdi);
            }



            //Application.Run(new TEMP_JV());
            //Application.Run(new ND_NC_OptionsPrint());

        }
    }
}
