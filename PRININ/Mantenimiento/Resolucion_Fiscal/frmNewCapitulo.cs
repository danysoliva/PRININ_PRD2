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

namespace PRININ.Mantenimiento.Resolucion_Fiscal
{
    public partial class frmNewCapitulo : DevExpress.XtraEditors.XtraForm
    {
        public frmNewCapitulo(int pIdRes, string ResDescripcion)
        {
            InitializeComponent();
            lblResolucion.Text = ResDescripcion;
            LoadRubros(pIdRes);
        }
        private void LoadRubros(int pIdResolucionSelected)
        {
            try
            {
                string sql = @"sp_get_lista_rubros_data_master";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_res", pIdResolucionSelected);
                dsResolucion1.master_rubros.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsResolucion1.master_rubros);
                conn.Close();
                //this.grResolucion.Enabled = false;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        //sp_get_detalle_rubro_capitulos_master_date
        private void LoadCaps(int pidRubro_)
        {
            try
            {
                string sql = @"sp_get_detalle_rubro_capitulos_master_date";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@id_rubro", pidRubro_);
                dsResolucion1.master_caps.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsResolucion1.master_caps);
                conn.Close();
                //this.grResolucion.Enabled = false;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void grLookEdit_Rubro_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grLookEdit_Rubro.Text))
                return;

            int IdRubro = Convert.ToInt32(grLookEdit_Rubro.EditValue);
            LoadCaps(IdRubro);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}