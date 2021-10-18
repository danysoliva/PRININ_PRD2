using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PRININ.Classes;
using PRININ.Gestion_de_Usuarios;
using PRININ.Numeracion_Fiscal;
using PRININ.Mantenimiento.Resolucion_Fiscal;

namespace PRININ.Mantenimiento
{
    public partial class frmMant : DevExpress.XtraEditors.XtraForm
    {
        public Users UsuarioLogueado;
        public frmMant(Users pUsersLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUsersLogin;
        }

        private void cmdMantCAI_Click(object sender, EventArgs e)
        {
            frmCAIProv frm = new frmCAIProv();
            frm.Show();
        }

        private void cmdUsuarios_Click(object sender, EventArgs e)
        {
            frmManUsuarios frm = new frmManUsuarios(UsuarioLogueado);
            frm.ShowDialog();
        }

        private void cmdPermisos_Click(object sender, EventArgs e)
        {
            if (UsuarioLogueado.ValidarNivelPermisos(11))
            {
                frmPermisosUsuarios frm = new frmPermisosUsuarios();
                frm.ShowDialog();
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta funcion! Permiso Requerido #11");
            }

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNumeracionFiscal_Click(object sender, EventArgs e)
        {
            frmNumeracionFiscal frm = new frmNumeracionFiscal(UsuarioLogueado);

            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmMantoResolucion frm = new frmMantoResolucion(UsuarioLogueado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}