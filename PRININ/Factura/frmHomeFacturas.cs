using DevExpress.XtraGrid.Views.Grid;
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

namespace PRININ.Factura
{
    public partial class frmHomeFacturas : Form
    {
        public frmHomeFacturas(string ptema)
        {
            //this.theme
            InitializeComponent();
            LoadFacturas();
        }

        private void LoadFacturas()
        {
            try
            {
                string sql = @"sp_get_home_facturas_united";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_rub", pIdRubroSelected);
                //cmd.Parameters.AddWithValue("@id_rub", pIdRubroSelected);
                dsFacturasPRD1.home_facturas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFacturasPRD1.home_facturas);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void pS_Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pS_Button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Ver Factura
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsFacturasPRD.home_facturasRow)gridView.GetFocusedDataRow();

            frmFacturaPRD frm = new frmFacturaPRD(row.id);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

        }
    }
}
