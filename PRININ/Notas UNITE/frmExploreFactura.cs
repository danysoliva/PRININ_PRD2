using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PRININ.Classes;
using PRININ.Factura;
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

namespace PRININ.Notas_UNITE
{
    public partial class frmExploreFactura : DevExpress.XtraEditors.XtraForm
    {
        public int IdFactura;
        public int IdSistemaFactura;//1 Unite y 2 M3
        public string FacturaNum;
        public frmExploreFactura()
        {
            InitializeComponent();
            LoadFacturas();
        }
        public string CodeWindow { get { return "WD0001"; } }

        private void LoadFacturas()
        {
            try
            {
                string sql = @"[sp_get_home_facturas_united_selection_v2]";
                DBOperations dp = new DBOperations();
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
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

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Seleccion de Factura.
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsFacturasPRD.home_facturasRow)gridView.GetFocusedDataRow();

            IdFactura = row.id;
            FacturaNum = row.numero_factura_hn;
            IdSistemaFactura = row.source_invoice;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}