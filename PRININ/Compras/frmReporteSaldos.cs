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
    public partial class frmReporteSaldos : Form
    {
        public frmReporteSaldos()
        {
            InitializeComponent();
            LoadResolucion();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(dtFechaDesde.Text) || string.IsNullOrEmpty(dtFechaHasta.Text))
            {
                CajaDialogo.Error("Debe seleccionar un rango de fechas valido!");
                return;
            }

            try
            {
                //object row0 = this.grResolucion.GetSelectedDataRow();
                DataRowView dataRow = grResolucion.GetSelectedDataRow() as DataRowView;

                if (dataRow == null)
                {

                    string sql = @"EXEC	[dbo].[get_resumen_capitulos_saldos] @fecha_desde = '" +
                            string.Format("{0:MM/dd/yyyy}", Convert.ToDateTime(dtFechaDesde.Text)) +
                            "', @fecha_hasta = '" + string.Format("{0:MM/dd/yyyy}", Convert.ToDateTime(dtFechaHasta.Text)) + "'";
                    DBOperations dp = new DBOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    dsCompras1.saldos_rubros.Clear();
                    adat.Fill(dsCompras1.saldos_rubros);
                    conn.Close();
                }

                else {

                    var data = ((PRININ.Compras.dsCompras.resolucionRow)dataRow.Row).codigo;
                    //DataRow data =


                    //string sql = @"EXEC	[dbo].[get_resumen_rubros_saldos] @fecha_desde = '" + 
                    //             string.Format("{0:MM/dd/yyyy}", Convert.ToDateTime(dtFechaDesde.Text)) +
                    //             "', @fecha_hasta = '"+ string.Format("{0:MM/dd/yyyy}", Convert.ToDateTime(dtFechaHasta.Text)) + "'";
                    string sql = @"EXEC	[dbo].[get_resumen_capitulos_saldos] @fecha_desde = '" +
                                 string.Format("{0:MM/dd/yyyy}", Convert.ToDateTime(dtFechaDesde.Text)) +
                                 "', @fecha_hasta = '" + string.Format("{0:MM/dd/yyyy}", Convert.ToDateTime(dtFechaHasta.Text)) + "'" + ", @id_resolucion = " + Convert.ToInt32(data) + "";
                    DBOperations dp = new DBOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    dsCompras1.saldos_rubros.Clear();
                    adat.Fill(dsCompras1.saldos_rubros);
                    conn.Close();
                }

             
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

        private void LoadResolucion()
        {
            try
            {
                string sql = @"SELECT [codigo]
                                     ,[descripcion]
                               FROM [dbo].[resolucion]";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsCompras1.resolucion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras1.resolucion);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

     

    }
}
