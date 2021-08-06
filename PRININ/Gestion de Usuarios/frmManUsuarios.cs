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
using PRININ.Gestion_de_Usuarios;

namespace PRININ.Gestion_de_Usuarios
{
    public partial class frmManUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public Users UsuarioLogueado;
        DBOperations dp;
        public frmManUsuarios(Users pUsersLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUsersLogin;
            dp = new DBOperations();

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            if (UsuarioLogueado.SuperUserDo == true)
            {
                try
                {
                    string sql = @"SELECT [id]
                                  ,[alias]
                                  ,[password]
                                  ,[habilitado]
                                  ,[nombre]
                                  ,[apellido]
                                  ,[super_user]
                              FROM [dbo].[USUARIOS_CONFIG]";
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    //cmd.Parameters.Add("id_user", PgSqlType.Int).Value = ;
                    dsUsers.Usuarios.Clear();
                    adat.Fill(dsUsers.Usuarios);
                    conn.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show("No se pudo cargar la lista de usuarios!" + ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    string sql = @"SELECT [id]
                                  ,[alias]
                                  ,[password]
                                  ,[habilitado]
                                  ,[nombre]
                                  ,[apellido]
                                  ,[super_user]
                              FROM [dbo].[USUARIOS_CONFIG]
                              where id = " + UsuarioLogueado.UserId;
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    //cmd.Parameters.Add("id_user", PgSqlType.Int).Value = ;
                    dsUsers.Usuarios.Clear();
                    adat.Fill(dsUsers.Usuarios);
                    conn.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show("No se pudo cargar la lista de usuarios!" + ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }


        private void cmdSave_Click(object sender, EventArgs e)
        {
            //Nivel de Permiso Crear Usuario
            if (UsuarioLogueado.ValidarNivelPermisos(10))
            {
                Users usx = new Users();
                frmUser fx = new frmUser(frmUser.TipoEdicion.Nuevo, usx);
                if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CargarUsuarios();
                }
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #10");
            }

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void repositoryEditar_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Users usx = new Users();
            var gridView = (GridView)gridControl1.FocusedView;
            DataRow row = (DataRow)gridView.GetFocusedDataRow();
            usx.RecuperarRegistrosGestion(row["alias"].ToString());

            frmUser fx = new frmUser(pTipo: frmUser.TipoEdicion.Editar, pUser: usx);
            if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarUsuarios();
            }
        }
    }
}