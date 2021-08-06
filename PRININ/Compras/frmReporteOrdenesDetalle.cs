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
using System.Windows.Forms;

namespace PRININ.Compras
{
    public partial class frmReporteOrdenesDetalle : Form
    {
        public frmReporteOrdenesDetalle()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtFechaDesde.Text) || string.IsNullOrEmpty(dtFechaHasta.Text))
            {
                CajaDialogo.Error("Debe seleccionar un rango de fechas valido!");
                return;
            }

            try
            {

                string sql = @"SELECT id
		                             ,proveedor
		                             ,codigo_proveedor
		                             ,fecha
		                             ,moneda
		                             ,(select descripcion
		                               from PRININ.dbo.conf_monedas
		                               where id=moneda)as moneda_name
		                             ,CASE WHEN cerrada = 0 THEN 'Abierta'
									 else 'Cerrada' 
									 END as estado
                                     ,coalesce(numero,'')as numero
                                     ,coalesce([num_factura],'')as num_factura
                                     ,coalesce([num_oc_sar],'')as num_oc_sar
									 ,(SELECT sum([cantidad]*[precio])
										FROM [dbo].[ORDEN_COMPRA_D] dd
										where dd.[id_orden_compra] = oc.id)as total
                            FROM PRININ.dbo.ORDEN_COMPRA oc 
                                    where fecha between @desde and @hasta";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("desde", SqlDbType.DateTime).Value = dtFechaDesde.EditValue;
                cmd.Parameters.Add("hasta", SqlDbType.DateTime).Value = dtFechaHasta.EditValue;
                dsCompras1.resumen_oc_rpt.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras1.resumen_oc_rpt);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
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
