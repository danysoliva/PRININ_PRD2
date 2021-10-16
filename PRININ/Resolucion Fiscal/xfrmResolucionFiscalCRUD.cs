using DevExpress.XtraEditors;
using PRININ.Classes;
using PRININ.Resolucion_Fiscal.Model;
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

namespace PRININ.Resolucion_Fiscal
{
    public partial class xfrmResolucionFiscalCRUD : DevExpress.XtraEditors.XtraForm
    {
        int modoForm;
        ResolucionFiscal ResolucionFiscal = new ResolucionFiscal();

        public xfrmResolucionFiscalCRUD(ResolucionFiscal pResolucionFiscal, int pModoForm)
        {
            InitializeComponent();

            modoForm = pModoForm;
            ResolucionFiscal = pResolucionFiscal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xfrmResolucionFiscalCRUD_Load(object sender, EventArgs e)
        {
            if (modoForm==2)
            {
                txtCodigo.Text = ResolucionFiscal.Codigo.ToString();
                txtDescripcion.Text = ResolucionFiscal.Descripcion;
                deInicio.EditValue = ResolucionFiscal.FechaInicio;
                deFin.EditValue = ResolucionFiscal.FechaFin;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
            
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                CajaDialogo.Error("DEBE DE INGRESAR UN CÓDIGO");
                return;
            }
            
            if (string.IsNullOrEmpty(deInicio.Text))
            {
                CajaDialogo.Error("DEBE DE INGRESAR UNA FECHA INICIAL");
                return;
            }
            
            if (string.IsNullOrEmpty(deFin.Text))
            {
                CajaDialogo.Error("DEBE DE INGRESAR UNA FECHA FINAL");
                return;
            }

            try
            {

            switch (modoForm)
            {
                case 1:
                    DBOperations dp = new DBOperations();

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
                        {
                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.sp_insert_resolucion_fiscal", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = txtCodigo.Text;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                            cmd.Parameters.Add("@fecha_i", SqlDbType.Date).Value =deInicio.EditValue;
                            cmd.Parameters.Add("@fecha_f", SqlDbType.Date).Value = deFin.EditValue;

                            cmd.ExecuteNonQuery();

                            this.DialogResult = DialogResult.OK;
                            //CajaDialogo.Information("Datos");

                            cnx.Close();

                        }
                    break;

                    case 2:
                        DBOperations dp2 = new DBOperations();

                        using (SqlConnection cnx = new SqlConnection(dp2.ConnectionStringPRININ))
                        {
                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.sp_update_resolucion_fiscal", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ResolucionFiscal.ID;
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = txtCodigo.Text;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                            cmd.Parameters.Add("@fecha_i", SqlDbType.Date).Value = deInicio.EditValue;
                            cmd.Parameters.Add("@fecha_f", SqlDbType.Date).Value = deFin.EditValue;

                            cmd.ExecuteNonQuery();

                            this.DialogResult = DialogResult.OK;
                            //CajaDialogo.Information("Datos");

                            cnx.Close();

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