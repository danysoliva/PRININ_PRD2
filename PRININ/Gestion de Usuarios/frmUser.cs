using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRININ.Classes;
using System.Data.SqlClient;

namespace PRININ.Gestion_de_Usuarios
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoEdicion
        {
            Nuevo = 1,
            Editar = 2
        }

        private bool ValidoContrasenia;

        private SqlConnection conn;
        DBOperations op;
        private TipoEdicion vTipoEdition;
        private Users UserParametro;

        public frmUser(TipoEdicion pTipo, Users pUser)
        {
            InitializeComponent();
            vTipoEdition = pTipo;
            op = new DBOperations();
            UserParametro = pUser;

            switch (vTipoEdition)
            {
                case TipoEdicion.Nuevo:
                    txtAlias.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    chkUsuarioHabilitado.Checked = true;
                    chkSuperUsuario.Checked = false;
                    ValidoContrasenia = false;
                    txtPass.Text = "";
                    txtConfirmar.Text = "";
                    break;
                case TipoEdicion.Editar:
                    //txtConfirmar.Text = UserParametro.Pass;
                    txtAlias.Text = UserParametro.Alias;
                    txtNombre.Text = UserParametro.Nombre;
                    txtApellido.Text = UserParametro.Apellido;
                    chkUsuarioHabilitado.Checked = UserParametro.habilitado;
                    txtPass.Text = UserParametro.DecryptPassword(UserParametro.Pass);
                    txtConfirmar.Text = UserParametro.DecryptPassword(UserParametro.Pass);
                    if (UserParametro.SuperUserDo == false)
                    {
                        chkSuperUsuario.Enabled = false;        
                    }
                    chkSuperUsuario.Checked = UserParametro.SuperUserDo;
                    ValidoContrasenia = true;
                    break;
            }
        }

        private void cmdSAve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlias.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Los campos: Alias, Nombre y Apellidos no pueden quedar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtConfirmar.Text != txtPass.Text)
            {
                ValidoContrasenia = false;
            }
            else
            {
                ValidoContrasenia = true;
            }

            if (ValidoContrasenia)
            {
                switch (vTipoEdition)
                {
                    case TipoEdicion.Nuevo:
                        UserParametro = new Users();
                        UserParametro.Alias = txtAlias.Text.Trim();
                        UserParametro.Nombre = txtNombre.Text.Trim();
                        UserParametro.apellido = txtApellido.Text.Trim();
                        UserParametro.habilitado = chkUsuarioHabilitado.Checked;
                        UserParametro.SuperUserDo = chkSuperUsuario.Checked;
                        UserParametro.Pass = txtPass.Text;

                        if (UserParametro.GuardarNuevoUsuario())
                        {
                            CajaDialogo.Information("Guardado con exito!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }


                        break;
                    case TipoEdicion.Editar:
                        UserParametro.Alias = txtAlias.Text.Trim();
                        UserParametro.Nombre = txtNombre.Text.Trim();
                        UserParametro.apellido = txtApellido.Text.Trim();
                        UserParametro.habilitado = chkUsuarioHabilitado.Checked;
                        UserParametro.SuperUserDo = chkSuperUsuario.Checked;
                        UserParametro.Pass = txtPass.Text;
                        if (UserParametro.ModificarUsuario())
                        {
                            CajaDialogo.Information("Guardado con exito!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;
                }
            }
            else
            {
                CajaDialogo.Error("Las contraseñas no coinciden!");
                return;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}