using DevExpress.XtraEditors;
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

namespace PRININ.Compras
{
    public partial class frmseleccionarCapitulo : DevExpress.XtraEditors.XtraForm
    {
        public decimal saldo;
        public decimal pagos;
        public int id;
        public string descripcion;
        public frmseleccionarCapitulo(int pIdRubro)
        {
            InitializeComponent();
            LoadCapitulos(pIdRubro);
        }

        private void LoadCapitulos(int pIdRubroSelected)
        {
            try
            {
                //string sql = @"sp_get_lista_capitulos_a_exonerar_oc";
                string sql = @"[sp_get_lista_capitulos_a_exonerar_oc]";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_rub", pIdRubroSelected);
                cmd.Parameters.AddWithValue("@id_rub", pIdRubroSelected);
                //dsCompras1.capitulos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras1.capitulos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsCompras.capitulosRow)gridView.GetFocusedDataRow();

            descripcion = row.descripcion;
            id = row.id;
            this.DialogResult = DialogResult.OK;
        }
    }
}