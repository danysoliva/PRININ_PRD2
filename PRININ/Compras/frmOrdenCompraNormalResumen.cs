using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using PRININ.Classes;
using PRININ.RPTS;

namespace PRININ.Compras
{
    public partial class frmOrdenCompraNormalResumen : DevExpress.XtraEditors.XtraForm
    {
        public frmOrdenCompraNormalResumen()
        {
            InitializeComponent();
            LoadData();
        }

        private void cmdNueva_Click(object sender, EventArgs e)
        {
            frmOrdenCompraNormal frm = new frmOrdenCompraNormal(frmOrdenCompraNormal.TipoEdicion.insert);
            if (frm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void LoadData()
        {
            try
            {
                char filtro = '0';
                if (tgMostrarCerradas.IsOn)
                    filtro = '1';

                string sql = @"SELECT id
		                             ,proveedor
		                             ,codigo_proveedor
		                             ,fecha
		                             ,moneda
		                             ,(select descripcion
		                               from PRININ.dbo.conf_monedas
		                               where id=moneda)as moneda_name
		                             ,cerrada
                                     ,coalesce(numero,'')as numero
                                     ,coalesce([num_factura],'')as num_factura
                                     ,coalesce([num_oc_sar],'')as num_oc_sar
                            FROM PRININ.dbo.ORDENC_NORMAL
                            where cerrada = " + filtro + " " +
                            "order by numero DESC";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsCompras1.resumen_oc_n.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras1.resumen_oc_n);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void repositoryItemButtonPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridMain.FocusedView;
            var row = (dsCompras.resumen_oc_nRow)gridView.GetFocusedDataRow();

            string num = row.numero;

            num = "Orden #" + num;
            
            //encabezado para la orden de compra normal
            try
            {
                string sql = @"SELECT [id]
		                            ,[proveedor]
                                    ,[codigo_proveedor]
                                    ,[rtn]
                                    ,[direccion]
                                    ,coalesce([contacto],'')as contacto
                                    ,coalesce([telefono],'')as telefono
                                    ,[fecha]
                                    ,[fecha_vence]
                                    ,[moneda]
                                    ,[referencia]
                                    ,[cerrada]
                                    ,coalesce([obs],'')as obs
		                            ,(SELECT descripcion 
			                            FROM PRININ.dbo.conf_monedas
			                            where id=moneda)as moneda
                                    ,[numero]
                                    ,[num_factura]
                                    ,[num_oc_sar]
                                    ,[otros]
		                      FROM [dbo].[ORDENC_NORMAL]
		                        where [cerrada] = 0 and id =" + row.id.ToString();
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_enc_normal.Clear();
                adat.Fill(dsCompras1.oc_enc_normal);

                //detalle para orden de compra normal

                string sql2 = @"SELECT [id]
                                  ,[id_orden_compra]
                                  ,coalesce([codigo],'') as codigo
                                  ,[descripcion]
                                  ,[cantidad]
                                  ,[precio]
                                  ,[Impuesto]
	                              ,((cantidad * precio)) as total_f
                              FROM [dbo].[ORDENC_NORMALDe]
                              where [id_orden_compra] =" + row.id.ToString();
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                SqlDataAdapter adat2 = new SqlDataAdapter(sql2, conn);
                dsCompras1.oc_detalle_normal.Clear();
                adat2.Fill(dsCompras1.oc_detalle_normal);

                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            decimal total = 0;
            decimal impuesto = 0;
            decimal otros = 0;

            //calculo del valor otros (ejem. Fletes)
            foreach (dsCompras.oc_enc_normalRow row2 in dsCompras1.oc_enc_normal)
            {
                otros = +row2.otros;
            }

            //suma del total= canitdad * precio | suma del impuesto.
            foreach (dsCompras.oc_detalle_normalRow row1 in dsCompras1.oc_detalle_normal)
            {
                total += (row1.cantidad * row1.precio);
                impuesto += (row1.Impuesto);
            }           

            int printcount = dsCompras1.oc_detalle_normal.Rows.Count;

            int rowwant = 21 - (printcount);

            if (rowwant > 0)
            {
                DataRow workRow;
                for (int i = 1; i <= rowwant; i++)
                {
                    workRow = dsCompras1.oc_detalle_normal.NewRow();
                    workRow["id"] = DBNull.Value;
                    workRow["id_orden_compra"] = DBNull.Value;
                    workRow["codigo"] = DBNull.Value;
                    

                    if (i == 1)
                    {
                        workRow["descripcion"] = "      ****Ultima Linea****";
                    }
                    workRow["cantidad"] = DBNull.Value;
                    workRow["precio"] = DBNull.Value;
                    workRow["Impuesto"] = DBNull.Value;
                    workRow["total_f"] = DBNull.Value;

                    dsCompras1.oc_detalle_normal.Rows.Add(workRow);
                }

                RPT_OrdenCompra_Normal report = new RPT_OrdenCompra_Normal(num, total, impuesto, otros) { DataSource = dsCompras1, DataMember = "oc_detalle_normal", ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                reportPrint.ShowPreview();
            }
            else
            {
                DataRow workRow;
                for (int i = 1; i <= rowwant; i++)
                {
                    workRow = dsCompras1.oc_detalle_normal.NewRow();
                    workRow["id"] = DBNull.Value;
                    workRow["id_orden_compra"] = DBNull.Value;
                    workRow["codigo"] = DBNull.Value;


                    if (i == 1)
                    {
                        workRow["descripcion"] = "      ****Ultima Linea****";
                    }
                    workRow["cantidad"] = DBNull.Value;
                    workRow["precio"] = DBNull.Value;
                    workRow["Impuesto"] = DBNull.Value;
                    workRow["total_f"] = DBNull.Value;

                    dsCompras1.oc_detalle_normal.Rows.Add(workRow);
                }

                RPT_OrdenCompra_Normal report = new RPT_OrdenCompra_Normal(num, total, impuesto, otros) { DataSource = dsCompras1, DataMember = "oc_detalle_normal", ShowPrintMarginsWarning = false };
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                reportPrint.ShowPreview();
            }
        }

        private void button_cerrar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridMain.FocusedView;
            var row = (dsCompras.resumen_oc_nRow)gridView.GetFocusedDataRow();

            DialogResult r = CajaDialogo.Pregunta("Desea cerrar esta Orden?");
            if (r != DialogResult.Yes)
            {
                return;
            }
            string sql = @"UPDATE [dbo].[ORDENC_NORMAL]
                             SET [cerrada] = 1
                           WHERE [id] = @id";
            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = row.id.ToString();
                cmd.ExecuteNonQuery();

                LoadData();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void tgMostrarCerradas_Toggled(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmReporteOrdDetalleNormal frmRpts = new frmReporteOrdDetalleNormal();
            frmRpts.Show();
        }

        private void cmdReportes_Click(object sender, EventArgs e)
        {

        }
    }
}