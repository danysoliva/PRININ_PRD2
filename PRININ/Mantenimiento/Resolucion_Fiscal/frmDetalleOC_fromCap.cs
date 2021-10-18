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
    public partial class frmDetalleOC_fromCap : DevExpress.XtraEditors.XtraForm
    {
        public frmDetalleOC_fromCap(int pIdCap_)
        {
            InitializeComponent();
            LoadOC(pIdCap_);
        }

        private void LoadOC(int pIdCap)
        {
            try
            {
                //char filtro = '0';
                //if (tgMostrarCerradas.IsOn)
                //    filtro = '1';

                string sql = @"sp_get_detalle_ordenes_from_cap";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcap", pIdCap);
                dsResolucion1.detalle_oc_from_cap.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsResolucion1.detalle_oc_from_cap);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            if (dsResolucion1.detalle_oc_from_cap.Rows.Count < 1)
            {
                CajaDialogo.Error("No hay registros disponibles para exportar!");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }
    }
}