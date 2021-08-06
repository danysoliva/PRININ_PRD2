using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using PRININ.Classes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace PRININ.Pedidos
{
    public partial class frmPedidos : DevExpress.XtraEditors.XtraForm
    {
        public frmPedidos()
        {
            InitializeComponent();
            loadpedido();
        }

        private void loadpedido()
        {
            string sql = @"SELECT [id]
	                          ,[numero_pedido]
                              ,[cod_cliente]
                              ,[cliente]
                              ,[cliente_direccion]
                              ,[direccion_entrega]
                              ,[fecha_pedido]
                              ,[fecha_entrega]
                              ,[contacto]
                              ,[Sunumero_orden]
                              ,[cond_entrega]
                              ,[metood_entrega]
                              ,(Select M.descripcion FROM PRININ.dbo.conf_monedas M where M.id = P.moneda) as moneda
                              ,[numero_orden]
                              ,[ntra_ref]
                          FROM [dbo].[CONFIRMACION_PEDIDO] P
                          where enable = 0
                          ORDER BY [numero_pedido] DESC";
            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPedidos.resumenpedidos.Clear();
                adat.Fill(dsPedidos.resumenpedidos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            frmPedidosNew frmAdd = new frmPedidosNew();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                loadpedido();
            }
        }

        private void repositoryItemPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridPedidos.FocusedView;
            var row = (dsPedidos.resumenpedidosRow)gridView.GetFocusedDataRow();
            string num = row.numero_pedido;

            num = "Orden #" + num;

            try
            {
                //Ecnabezado
                string sql = @"SELECT [id]
								    ,[numero_pedido]
                                    ,[cod_cliente]
                                    ,[cliente]
                                    ,[cliente_direccion]
                                    ,[direccion_entrega]
                                    ,[fecha_pedido]
                                    ,[fecha_entrega]
                                    ,[fecha_2]
                                    ,[contacto]
                                    ,[Sunumero_orden]
                                    ,[cond_entrega]
                                    ,[metood_entrega]
								    ,[numero_orden]
								    ,[ntra_ref]
	                                ,(Select M.descripcion FROM PRININ.dbo.conf_monedas M where M.id = P.moneda) as moneda
								    ,[cliente_direccion2]
								    ,[cliente_direccion3]
								    ,[cliente_direccion4]
                                    ,[total_peso]
                                FROM [dbo].[CONFIRMACION_PEDIDO] P
                                where P.id = " + row.id.ToString();
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPedidos.pedidos_enc.Clear();
                adat.Fill(dsPedidos.pedidos_enc);


                //Detalle
                string sqlDet = @"SELECT [id]
                                    ,[id_pedido]
                                    ,[numero_articulo]
                                    ,[descripcion]
                                    ,[fecha_carga]
                                    ,[cantidad]
                                    ,[importe]
                                FROM [dbo].[CONFIRMACION_PEDIDO_D]
                                where id_pedido =" + row.id.ToString();
                SqlCommand cmdD = new SqlCommand(sqlDet, conn);
                SqlDataAdapter adatD = new SqlDataAdapter(cmdD);
                dsPedidos.detallePedido.Clear();
                adatD.Fill(dsPedidos.detallePedido);

                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            decimal total = 0;
            foreach (dsPedidos.detallePedidoRow row1 in dsPedidos.detallePedido)
            {
                total += (row1.importe * row1.cantidad);
            }

            int printCount = dsPedidos.detallePedido.Rows.Count;

            int rowwant = 17 - (printCount);

            if (rowwant > 0)
            {
                DataRow workRow;
                for (int i = 0; i < rowwant; i++)
                {
                    workRow = dsPedidos.detallePedido.NewRow();
                    workRow["id"] = DBNull.Value;
                    workRow["numero_articulo"] = DBNull.Value;
                    if (i == 1)
                    {
                        workRow["descripcion"] = "       ****Ultima Linea****";
                        workRow["descripcion"] = "       ****Ultima Linea****";
                    }
                    else
                    {
                        workRow["descripcion"] = DBNull.Value;
                        workRow["descripcion"] = DBNull.Value;
                    }
                    workRow["cantidad"] = DBNull.Value;
                    workRow["importe"] = DBNull.Value;
                    workRow["precio_unit"] = DBNull.Value;
                    workRow["total_f"] = DBNull.Value;

                    dsPedidos.detallePedido.Rows.Add(workRow);
                }
            }

            RptPedidos report = new RptPedidos(num, total) {DataSource = dsPedidos, DataMember = "detallePedido", ShowPrintMarginsWarning = false};
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printreport = new ReportPrintTool(report);
            printreport.ShowPreview();
        }
    }
}
