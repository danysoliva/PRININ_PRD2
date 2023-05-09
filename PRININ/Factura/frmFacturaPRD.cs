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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRININ.Factura
{
    public partial class frmFacturaPRD : Form
    {
        int pId;
        FacturaH fact1;

        public string CodeWindow { get { return "WD0001"; } }

        public frmFacturaPRD(int pid)
        {
            InitializeComponent();
            pId = pid;
            //LoadTax();
            fact1 = new FacturaH();
            if (fact1.RecuperarRegistro(pid))
            {
                lblFacturaUnited.Text = fact1.invoice_number;
                if (string.IsNullOrEmpty(fact1.invoice_number_fiscal))
                {
                    DocsFiscales docs = new DocsFiscales();
                    if (docs.RecuperarRegistro(DocsFiscales.DocType.Factura))
                    {
                        txtFacturaFiscal.Text = docs.Leyenda + GetLastEight(fact1.invoice_number);
                    }
                }
                else
                {
                    txtFacturaFiscal.Text = fact1.invoice_number_fiscal;
                }
                
                //gridLookUpEdit_ISV.EditValue = fact1.local_tax_id;
                lblCodigoCliente.Text = fact1.customer_code;
                lblNombreCliente.Text = fact1.customer_long_name;
                lblRTN.Text = fact1.customer_rtn;
                //lblRegistroExonerado.Text = fact1.record_ex;
                lblDiasCredito.Text = fact1.credit_days.ToString();
                lblFechaFactura.Text = string.Format("{0:dd/MM/yyyy}", fact1.invoice_date); 
                lblFechaFacturaVence.Text = string.Format("{0:dd/MM/yyyy}", fact1.due_date);
                lblUser.Text = fact1.created_by;
                lblOrdenCompra.Text = fact1.cust_po_number;
                lblTerminoCredito.Text = fact1.Credit_term_description;
                lblDireccion.Text = fact1.shipping_addess;
                lblPais.Text = fact1.PaisNombre;
                lblMoneda.Text = fact1.CurrencyDescripcion;
                txtLineaAdicional1.Text = fact1.aditional_line1;
                txtLineaAdicional2.Text = fact1.aditional_line2;
                txtLineaAdicional3.Text = fact1.aditional_line3;
                txtLineaAdicional4.Text = fact1.aditional_line4;
                txtLineaAdicional5.Text = fact1.aditional_line5;
                txtLineaAdicional6.Text = fact1.aditional_line6;
                txtID_SAG.Text = fact1.ID_SAG;
                txtOC_Excenta.Text = fact1.OC_Exenta;
                txtRegistroExoneradoC.Text = fact1.RegistroExoneradoC;

                txtTasaCambio.Text = string.Format("{0:###,##0.0000}", fact1.TasaCambio);
                txtTotalFacturaLPS.Text = string.Format("{0:###,##0.00}", fact1.TasaCambio * Convert.ToDecimal(fact1.TotalFacturaUSD));
                txtTotalFacturaUSD.Text = string.Format("{0:###,##0.00}", fact1.TotalFacturaUSD);
                txtSubTotal.Text = string.Format("{0:###,##0.00}", fact1.SubTotal);
                txtTotalDescuento.Text = string.Format("{0:###,##0.00}", fact1.TotalDiscount);
                txtTotalISV.Text = string.Format("{0:###,##0.00}", fact1.TotalISV);
                LoadDetalleFactura(pid);
                //txtTotalFacturaUSD.Text = string.Format("{0:###,##0.00}", 0); 
            }
        }

        private string GetLastEight(string invoice_number)
        {
            if(invoice_number.Length < 8)
            {
                return "Error: 03";
            }

            String var = invoice_number;
            String Var_Sub = "";
            if (var != null & var != "")
            {
                int tam_var = var.Length;
                Var_Sub = var.Substring((tam_var - 8), 8);
            }
            return Var_Sub;
        }

        private void LoadTax()
        {
            try
            {
                string sql = @"sp_get_lista_tax_habilitados_facturas";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", pId);
                dsFacturasPRD1.taxes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFacturasPRD1.taxes);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalleFactura(int pid)
        {
            try
            {
                string sql = @"sp_get_detalles_factura";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                //string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                string ConnectionString = dp.ConnectionStringPRININ;
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                dsFacturasPRD1.invoice_details.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFacturasPRD1.invoice_details);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void frmFacturaPRD_Load(object sender, EventArgs e)
        {
        }

        private void pS_Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pS_ButtonGuardar_Click(object sender, EventArgs e)
        {
            //DialogResult r = CajaDialogo.Pregunta();
            if (fact1 != null)
            {
                //int taxid = Convert.ToInt32(gridLookUpEdit_ISV.EditValue);
                //if (taxid == 0)
                //{
                //    CajaDialogo.Error("Debe seleccionar el tipo de impuesto sobre venta!");
                //    gridLookUpEdit_ISV.Focus();
                //    return;
                //}

                if (string.IsNullOrEmpty(txtFacturaFiscal.Text))
                {
                    CajaDialogo.Error("Es necesario generar el correlativo de factura local para guardar cambios!");
                    txtFacturaFiscal.Focus();
                    return;
                }

                fact1.aditional_line1 = txtLineaAdicional1.Text;
                fact1.aditional_line2 = txtLineaAdicional2.Text;
                fact1.aditional_line3 = txtLineaAdicional3.Text;
                fact1.aditional_line4 = txtLineaAdicional4.Text;
                fact1.aditional_line5 = txtLineaAdicional5.Text;
                fact1.aditional_line6 = txtLineaAdicional6.Text;
                fact1.cust_po_number = lblOrdenCompra.Text;
                fact1.RegistroExoneradoC = txtRegistroExoneradoC.Text;
                fact1.OC_Exenta = txtOC_Excenta.Text;
                fact1.ID_SAG = txtID_SAG.Text;

                fact1.TasaCambio = Convert.ToDecimal(txtTasaCambio.Text);
                fact1.invoice_number_fiscal = txtFacturaFiscal.Text;
                //fact1.local_tax_id = taxid;
                if (fact1.UpdateRegistro(pId))
                {
                    CajaDialogo.Information("Transacción exitosa!");
                }
            }
        }

        private void pS_ButtonImprimir_Click(object sender, EventArgs e)
        {
            //RPT_FacturaPRD
            DataSet datos = new DataSet();

            try
            {
                string sql = @"SELECT [number_of_units] as line_item_qty_saco
                                      ,[number_of_kg]as line_item_qty_kg
	                                  ,[um]as [line_unit_price]
                                      --,[product_code]
                                      ,[product_name]as [line_item_name_long]
                                      ,[unit_price]as [line_item_price_unit]
                                      ,[discount]
                                      ,[total_line]as [line_total_USD]
                                      /*,[tax_amount]
                                      ,[id_tax_type]
                                      ,[exchange_rate]
                                      ,[id_currency]
                                      ,*/
                                  FROM [dbo].[INV_DETAIL]
                                  where id_invoice_header =@id";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                //string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                string ConnectionString = dp.ConnectionStringPRININ;
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", fact1.Id);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //datos.Tables[0].TableName = "header";

                //datos.Tables[0].TableName = "detail";
                DataTable table1 = new DataTable();
                datos.Tables.Add(table1);
                adat.Fill(datos.Tables[0]);
                if (datos.Tables[0].Rows.Count <= 10)
                {
                    int conta = datos.Tables[0].Rows.Count;
                    while (conta < 10)
                    {
                        DataRow row = datos.Tables[0].NewRow();//  dsCompras.oc_d_normal.Newoc_d_normalRow();
                        datos.Tables[0].Rows.Add(row);// dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
                        datos.Tables[0].AcceptChanges();//dsCompras.AcceptChanges();
                        conta++;
                    }
                }
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            RPT_FacturaPRD report = new RPT_FacturaPRD(datos, fact1) { DataSource = datos, DataMember = "detail", ShowPrintMarginsWarning = false };
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }
    }
}
