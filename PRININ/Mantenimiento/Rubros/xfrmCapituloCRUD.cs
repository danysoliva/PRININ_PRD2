using DevExpress.XtraEditors;
using PRININ.Classes;
using PRININ.Mantenimiento.Rubros.Model;
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
    public partial class xfrmCapituloCRUD : DevExpress.XtraEditors.XtraForm
    {
        Capitulo capitulo = new Capitulo();

        int modoForm;
        public xfrmCapituloCRUD(Capitulo pCapitulo,int pModoForm)
        {
            InitializeComponent();

            capitulo = pCapitulo;
            modoForm = pModoForm;
            LoadRubros();
        }

        private void LoadRubros()
        {

            try
            {
                DBOperations dp = new DBOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_rubros", cnx);

                    dsRubros.Rubros.Clear();
                    da.Fill(dsRubros.Rubros);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
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

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
                        {
                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.sp_insert_capitulo_rubro", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                            cmd.Parameters.Add("@id_rubro", SqlDbType.VarChar).Value = lueRubro.EditValue;

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

                            SqlCommand cmd = new SqlCommand("dbo.sp_update_capitulo_rubro", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = capitulo.ID;
                            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                            cmd.Parameters.Add("@id_rubro", SqlDbType.VarChar).Value = lueRubro.EditValue;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xfrmCapituloCRUD_Load(object sender, EventArgs e)
        {

            try
            {

                if (modoForm == 2)
                {
                    txtCodigo.Text = capitulo.Codigo;
                    txtDescripcion.Text = capitulo.Descripcion;
                    lueRubro.EditValue = capitulo.RubroID;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }


}