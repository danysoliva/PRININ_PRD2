using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using PRININ.Classes;


namespace PRININ.Gestion_de_Usuarios
{
    public partial class frmPermisosUsuarios : DevExpress.XtraEditors.XtraForm
    {
        DBOperations dp = new DBOperations();
        public frmPermisosUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                string sql = @"SELECT 
                                  id,
                                  alias,
                                  password,
                                  habilitado,
                                  nombre,
                                  apellido,
                                  super_user
                                FROM [dbo].[USUARIOS_CONFIG]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsUsers.Usuarios.Clear();
                adat.Fill(dsUsers.Usuarios);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void repositoryItemButtonPermisos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsUsers.UsuariosRow)gridView1.GetFocusedDataRow();

            frmPermisosEdit conf_Edit = new frmPermisosEdit(row.id, row.alias, row.nombre, row.apellido);
            if (conf_Edit.ShowDialog() == DialogResult.OK)
            {
                CargarUsuarios();
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}