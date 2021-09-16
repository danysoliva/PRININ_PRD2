using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using PRININ.Classes;
using System.Reflection;
using PRININ.Factura;
using PRININ.DEV;

namespace PRININ
{
    public partial class LoginPrinin : DevExpress.XtraEditors.XtraForm
    {

        SecOps sec = new SecOps();
        public DataSet datos = new DataSet();
        //public Users UsuarioLogueado;

        private Users user1;

        public Users UsuarioLogueado
        {
            get { return user1; }
        }

        public string AssemblyVersion
        {
            get
            {
                //return ApplicationDeployment.CurrentDeployment.CurrentVersion;
                //return Application.ProductVersion;
                //System.Version version2 = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                //return version2;
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
                }
            }
        }

        public LoginPrinin()
        {
            InitializeComponent();

            txt_password.BackColor = Color.Transparent;
            txt_usuario.BackColor = Color.Transparent;

            lblVersion.Text = AssemblyVersion;
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            ValidateUserInfo();
        }

        private void ValidateUserInfo()
        {
            Users user = new Users();
             string usuario = user.EncrypPassword("Nutreco");//Users.EncrypPassword("Nutreco"); 
            #region OldCod
            //try
            //{
            //    datos = sec.ValidateUser(txt_usuario.Text.ToString(), txt_password.Text.ToString());
            //    UsuarioLogueado = new Users();
            //    if (UsuarioLogueado.RecuperarRegistros(txt_usuario.Text))
            //    {
            //        string name = UsuarioLogueado.Nombre;

            //        if (user.DecryptPassword(user.Pass) == txt_password.Text)
            //        {
            //            try
            //            {
            //                SqlConnection xconn = new SqlConnection();
            //                DBOperations dp = new DBOperations();
            //                xconn.ConnectionString = dp.ConnectionStringPRININ;
            //                xconn.Open();

            //                user.conn = xconn;
            //                UsuarioLogueado = user;

            //                this.DialogResult = DialogResult.OK;
            //                this.Close();

            //            }
            //            catch (Exception ec)
            //            {
            //                CajaDialogo.Error("No se pudo abrir la connexion a la base de datos!");
            //                return;
            //            }
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("Contraseña Incorrecta!");
            //            txt_password.Text = "";
            //            txt_password.Focus();
            //            return;
            //        }
            //    }

            //    this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            #endregion

            if (user.RecuperarRegistros(txt_usuario.Text))
            {
                if (!user.habilitado)
                {
                    CajaDialogo.Information("Este usuario no esta habilitado o no existe!");
                    return;
                }
                if (user.DecryptPassword(user.Pass) == txt_password.Text)
                {
                    try
                    {
                        SqlConnection xconn = new SqlConnection();
                        DBOperations dp = new DBOperations();
                        xconn.ConnectionString = dp.ConnectionStringPRININ;
                        xconn.Open();

                        user.conn = xconn;
                        user1 = user;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error("No se pudo abrir la connexion a la base de datos!");
                    }
                }
                else
                {
                    CajaDialogo.Error("Contraseña Incorrecta!");
                    txt_password.Text = "";
                    txt_password.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("No se pudo encontrar el usuario que usted ingreso, favor revise bien el alias de usuario.");
                txt_usuario.Focus();
            }

        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "Usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.Black;
            }
        }

        private void txt_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
            if (e.KeyCode == Keys.Tab)
            {
                txt_password.Focus();
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.Gray;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Contraseña")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_password.Properties.UseSystemPasswordChar = true;
                txt_password.Properties.PasswordChar = '·';
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdLogin_Click(sender, e);
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Properties.UseSystemPasswordChar = false;
                txt_password.Text = "Contraseña";
                txt_password.ForeColor = Color.Gray;
            }
        }

        private void LoginPrinin_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //txt_usuario.Text = "danys.oliva";
            //txt_password.Text = "Gto1804?";
            //ValidateUserInfo();
            frmHomeFacturas frm = new frmHomeFacturas("");
            //frm.MdiParent = this.MdiParent;
            frm.Show();
            //frmDEV frm = new frmDEV();
            //frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ValidateUserInfo();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pS_Button1_Click(object sender, EventArgs e)
        {
            ValidateUserInfo();
        }

        private void pS_Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}