using DevExpress.XtraEditors;
using PRININ.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRININ.Mantenimiento.Rubros
{
    public partial class xfrmRubrosCRUD : DevExpress.XtraEditors.XtraForm
    {
        int codigo,modoForm,id;
        string descripcion;
        

        public xfrmRubrosCRUD(int pid,int pcodigo, string pdescripcion, int pModoFom)
        {
            InitializeComponent();
            codigo = pcodigo;
            descripcion = pdescripcion;
            modoForm = pModoFom;
            id = pid;
        }

        private void xfrmRubrosCRUD_Load(object sender, EventArgs e)
        {
            if (modoForm==2)
            {
                txtCodigo.Text = codigo.ToString();
                txtDescripcion.Text = descripcion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    CajaDialogo.Error("DEBE DE INGRESAR UN CÓDIGO");
                    return;
                }

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    CajaDialogo.Error("DEBE DE INGRESAR UNA DESCRIPCIÓN");
                    return;
                }

                switch (modoForm)
                {
                    case 1:
                        DBOperations dp = new DBOperations();

                        using (SqlConnection cnx= new SqlConnection(dp.ConnectionStringPRININ))
                        {
                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.sp_insert_rubro", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = txtCodigo.Text;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                            this.DialogResult = DialogResult.OK;
                        }
                        break;

                    case 2:
                        DBOperations dp2 = new DBOperations();

                        using (SqlConnection cnx = new SqlConnection(dp2.ConnectionStringPRININ))
                        {
                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.sp_update_rubro", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = txtCodigo.Text;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;

                            cmd.ExecuteNonQuery();

                            cnx.Close();
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
