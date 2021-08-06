using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PRININ.Classes;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace PRININ.Compras
{
    public partial class frmReporteOrdDetalleNormal : Form
    {
        public frmReporteOrdDetalleNormal()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtFechaDesde.Text) || string.IsNullOrEmpty(dtFechaHasta.Text))
            {
                CajaDialogo.Error("No puede dejear los campos de fecha en blanco!");
                return;
            }

            try
            {
                string sql = @"SELECT [id]
                                ,[proveedor]
                                ,[codigo_proveedor]
                                ,[fecha]
                                ,[moneda]
	                            ,(Select descripcion 
		                            FROM PRININ.dbo.conf_monedas
		                            where id = moneda) as moneda_name
                                ,CASE WHEN cerrada = 0 THEN 'Abierta'
								else 'Cerrada'
								END as estado
                                ,coalesce([numero],'')as numero
                                ,coalesce([num_factura],'')as num_factura
                                ,coalesce([num_oc_sar],'')as num_oc_sar
	                            ,(SELECT sum(dd.[cantidad]*dd.[precio])
		                            FROM dbo.ORDENC_NORMALDe dd
		                            where dd.id_orden_compra = oc.id) as total
                            FROM [dbo].[ORDENC_NORMAL]  oc
                            where oc.fecha between @desde and @hasta";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("desde", SqlDbType.DateTime).Value = dtFechaDesde.EditValue;
                cmd.Parameters.Add("hasta", SqlDbType.DateTime).Value = dtFechaHasta.EditValue;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras.resumen_oc_rptNormal.Clear();
                adat.Fill(dsCompras.resumen_oc_rptNormal);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                CajaDialogo.Error("No hay informacion que convertir a EXCEL!");
                return;
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    gridControl1.ExportToXlsx(dialog.FileName);
                }
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string Estado = View.GetRowCellDisplayText(e.RowHandle, View.Columns["estado"]);
                switch (Estado)
                {
                    case "Abierta":
                        e.Appearance.BackColor = Color.FromArgb(158, 219, 149);
                        break;
                    case "Cerrada":
                        e.Appearance.BackColor = Color.Red;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
