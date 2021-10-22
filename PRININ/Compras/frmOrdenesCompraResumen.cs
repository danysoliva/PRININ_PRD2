using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using PRININ.Classes;
using PRININ.RPTS;
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
    public partial class frmOrdenesCompraResumen : Form
    {
        public frmOrdenesCompraResumen()
        {
            InitializeComponent();
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
                            FROM dbo.ORDEN_COMPRA 
                            where cerrada = " + filtro + "" +
                            "order by numero DESC";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsCompras1.resumen_oc.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras1.resumen_oc);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdNueva_Click(object sender, EventArgs e)
        {
            frmOrdenCompra frm = new frmOrdenCompra(frmOrdenCompra.TipoEdicion.Insert);
            if (frm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void tgMostrarCerradas_Toggled(object sender, EventArgs e)
        {
            LoadData();
        }

        private void repositoryItemButtonPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridMain.FocusedView;
            var row = (dsCompras.resumen_ocRow)gridView.GetFocusedDataRow();
            string num = row.numero;

            DBOperations dps = new DBOperations();
            SqlConnection con = new SqlConnection(dps.ConnectionStringPRININ);
            con.Open();
            SqlCommand command = con.CreateCommand();

            command.CommandText = @"SELECT resolucion from ORDEN_COMPRA
							                      where id =" + row.id.ToString();
            //command.Parameters.Add("resolucion", SqlDbType.Int).Value = row["resolucion"];
            string resolucionn = command.ExecuteScalar().ToString();

            string resolucion = "-"+ resolucionn;

            num = "Orden #" + num;
            
            try
            {
                //Encabezado
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
                                      ,coalesce(obs,'')as obs
	                                  ,(select descripcion
		                                from PRININ.dbo.conf_monedas
		                                where id=moneda)as moneda
                                      ,numero
                                      ,resolucion
                                      ,[num_factura]
                                      ,[num_oc_sar]
                                  FROM [dbo].[ORDEN_COMPRA]
                                  where id =" + row.id.ToString();
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_enc.Clear();
                adat.Fill(dsCompras1.oc_enc);


                //Detalle
                string sqlD = @"SELECT [id]
                                      ,[id_orden_compra]
                                      ,coalesce([codigo],'') as codigo
                                      ,[descripcion]
                                      ,[cantidad]
                                      ,[precio]
                                      ,[id_rubro]
	                                  ,(cantidad * precio) as total_f
	                                  ,(SELECT(cast(rr.[codigo] as varchar) + ' - ' +rr.[descripcion]) as descripcion
                                        FROM [dbo].[RUBROS] rr
                                        where rr.enable = 1 and rr.id = id_rubro) as nombre_rubro
                                  FROM [dbo].[ORDEN_COMPRA_D]
                                  where id_orden_compra =" + row.id.ToString();

                SqlCommand cmdD = new SqlCommand(sqlD, conn);
                SqlDataAdapter adatD = new SqlDataAdapter(cmdD);
                dsCompras1.oc_detalle.Clear();
                adatD.Fill(dsCompras1.oc_detalle);

                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            decimal total = 0;
            foreach (dsCompras.oc_detalleRow row1 in dsCompras1.oc_detalle)
            {
                total += (row1.cantidad * row1.precio);
            }

            int printcount = dsCompras1.oc_detalle.Rows.Count;

            int rowwant = 20 - (printcount);

            if (rowwant > 0)
            {
                DataRow workRow;
                for (int i = 1; i <= rowwant; i++)
                {
                    workRow = dsCompras1.oc_detalle.NewRow();
                    workRow["id"] = DBNull.Value;
                    workRow["id_orden_compra"] = DBNull.Value;
                    workRow["codigo"] = DBNull.Value;

                    if (i == 1)
                    {
                        workRow["descripcion"] = "       ****Ultima Linea****";
                        workRow["nombre_rubro"] = "       ****Ultima Linea****";
                    }
                    else
                    {
                        workRow["nombre_rubro"] = DBNull.Value;
                        workRow["descripcion"] = DBNull.Value;
                    }

                    workRow["cantidad"] = DBNull.Value;
                    workRow["precio"] = DBNull.Value;
                    workRow["total_f"] = DBNull.Value;
                    workRow["id_rubro"] = DBNull.Value;
                    dsCompras1.oc_detalle.Rows.Add(workRow);
                }
            }

            

            RPT_OrdenCompra report = new RPT_OrdenCompra(num, total, resolucion) { DataSource = dsCompras1, DataMember = "oc_detalle", ShowPrintMarginsWarning = false };
            //RPT_OrdenCompra report = new RPT_OrdenCompra(num) { DataSource = dsCompras1, ShowPrintMarginsWarning = false };
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void button_cerrar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Anular una orden
            DialogResult r = CajaDialogo.Pregunta("Realmente desea Cerrar (ANULAR) esta orden de compra?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                string sql = @"UPDATE [dbo].[ORDEN_COMPRA]
                                  SET [cerrada] = true
                               WHERE id = ";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                CajaDialogo.Information("Transaccion exitosa!");
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdReportes_Click(object sender, EventArgs e)
        {
            frmReporteSaldos frm = new frmReporteSaldos();
            frm.Show();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridMain.FocusedView;
            var row = (dsCompras.resumen_ocRow)gridView.GetFocusedDataRow();
            switch (e.Column.Name)
            {
                case "colFactura":
                    UpdateCampo(1,row.id, e.Value.ToString());
                    break;
                case "colOC":
                    UpdateCampo(2, row.id, e.Value.ToString());
                    break;
            }
        }

        private void UpdateCampo(int pTipo, int id, string Valor)
        {
            string sql = "";
            if(pTipo == 1)
            {
                sql = @"UPDATE [dbo].[ORDEN_COMPRA]
                           SET [num_factura] = '" + Valor+
                         "' WHERE id = " + id;
            }
            else
            {
                sql = @"UPDATE [dbo].[ORDEN_COMPRA]
                           SET [num_oc_sar] = '" + Valor +
                         "' WHERE id = " + id;
            }

            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                //CajaDialogo.Information("");
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmReporteOrdenesDetalle frm = new frmReporteOrdenesDetalle();
            frm.Show();
        }

        private void repositoryItemButtonPrint_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridMain.FocusedView;
            var row = (dsCompras.resumen_ocRow)gridView.GetFocusedDataRow();
            string num = row.numero;

            DBOperations dps = new DBOperations();
            SqlConnection con = new SqlConnection(dps.ConnectionStringPRININ);
            con.Open();
            SqlCommand command = con.CreateCommand();

            command.CommandText = @"SELECT resolucion from ORDEN_COMPRA
							                      where id =" + row.id.ToString();
            //command.Parameters.Add("resolucion", SqlDbType.Int).Value = row["resolucion"];
            string resolucionn = command.ExecuteScalar().ToString();

            string resolucion = "-" + resolucionn;

            num = "Orden #" + num;

            try
            {
                //Encabezado
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
                                      ,coalesce(obs,'')as obs
	                                  ,(select descripcion
		                                from PRININ.dbo.conf_monedas
		                                where id=moneda)as moneda
                                      ,numero
                                      ,resolucion
                                      ,[num_factura]
                                      ,[num_oc_sar]
                                  FROM [dbo].[ORDEN_COMPRA]
                                  where id =" + row.id.ToString();
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_enc.Clear();
                adat.Fill(dsCompras1.oc_enc);


                //Detalle
                string sqlD = @"SELECT [id]
                                      ,[id_orden_compra]
                                      ,coalesce([codigo],'') as codigo
                                      ,[descripcion]
                                      ,[cantidad]
                                      ,[precio]
                                      ,[id_rubro]
	                                  ,(cantidad * precio) as total_f
	                                  ,(SELECT(cast(rr.[codigo] as varchar) + ' - ' +rr.[descripcion]) as descripcion
                                        FROM [dbo].[RUBROS] rr
                                        where rr.enable = 1 and rr.id = id_rubro) as nombre_rubro
                                  FROM [dbo].[ORDEN_COMPRA_D]
                                  where id_orden_compra =" + row.id.ToString();

                SqlCommand cmdD = new SqlCommand(sqlD, conn);
                SqlDataAdapter adatD = new SqlDataAdapter(cmdD);
                dsCompras1.oc_detalle.Clear();
                adatD.Fill(dsCompras1.oc_detalle);

                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            decimal total = 0;
            foreach (dsCompras.oc_detalleRow row1 in dsCompras1.oc_detalle)
            {
                total += (row1.cantidad * row1.precio);
            }

            int printcount = dsCompras1.oc_detalle.Rows.Count;

            int rowwant = 20 - (printcount);

            if (rowwant > 0)
            {
                DataRow workRow;
                for (int i = 1; i <= rowwant; i++)
                {
                    workRow = dsCompras1.oc_detalle.NewRow();
                    workRow["id"] = DBNull.Value;
                    workRow["id_orden_compra"] = DBNull.Value;
                    workRow["codigo"] = DBNull.Value;

                    if (i == 1)
                    {
                        workRow["descripcion"] = "       ****Ultima Linea****";
                        workRow["nombre_rubro"] = "       ****Ultima Linea****";
                    }
                    else
                    {
                        workRow["nombre_rubro"] = DBNull.Value;
                        workRow["descripcion"] = DBNull.Value;
                    }

                    workRow["cantidad"] = DBNull.Value;
                    workRow["precio"] = DBNull.Value;
                    workRow["total_f"] = DBNull.Value;
                    workRow["id_rubro"] = DBNull.Value;
                    dsCompras1.oc_detalle.Rows.Add(workRow);
                }
            }



            RPT_OrdenCompra report = new RPT_OrdenCompra(num, total, resolucion) { DataSource = dsCompras1, DataMember = "oc_detalle", ShowPrintMarginsWarning = false };
            //RPT_OrdenCompra report = new RPT_OrdenCompra(num) { DataSource = dsCompras1, ShowPrintMarginsWarning = false };
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void button_cerrar_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Anular una orden
            DialogResult r = CajaDialogo.Pregunta("Realmente desea Cerrar (ANULAR) esta orden de compra?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                string sql = @"UPDATE [dbo].[ORDEN_COMPRA]
                                  SET [cerrada] = 1
                               WHERE id = @id";
                var gridView = (GridView)gridMain.FocusedView;
                var row = (dsCompras.resumen_ocRow)gridView.GetFocusedDataRow();

                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();
                conn.Close();
                CajaDialogo.Information("Transaccion exitosa!");
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
