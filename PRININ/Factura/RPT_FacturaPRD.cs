using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using PRININ.Classes;
using POS_Gasolinera_v1._0;
using System.Data.SqlClient;

namespace PRININ.RPTS
{
    public partial class RPT_FacturaPRD : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;

        public RPT_FacturaPRD(DataSet ds, FacturaH fact1)
        {
            InitializeComponent();
            this.ds = ds;
            //lblRegexo.Text = pRegistroExo;

            //foreach (DataRow data in ds.Tables["header"].Rows)
            //{
            //    Functions fn = new Functions();
            //    string codigo = data[9].ToString().ToUpper() + "-" +
            //                      fn.QuitSpecialChar(data["customer_long_name"].ToString().ToUpper()) + "-" +
            //                      fn.QuitSpecialChar(data[34].ToString().ToUpper()) + "-" +
            //                      fn.QuitSpecialChar(data[37].ToString().ToUpper()) + "-" +
            //                      fn.QuitSpecialChar(data[39].ToString().ToUpper());

            //    BarCodeFac.Text = codigo;
            //}
            //BarCodeFac.Text = lblFactura.Text + "*" + lblCliente.Text + "*" + lblDestino.Text + "*" + lblDireccion.Text;
            lblCliente.Text = fact1.customer_long_name;
            lblDireccion.Text = fact1.shipping_addess;
            lblRTN.Text = fact1.customer_rtn;
            lblDestino.Text = fact1.PaisNombre;
            lblFechaFactura.Text = string.Format("{0:dd/MM/yyyy}", fact1.invoice_date);
            lblFechaVence.Text = string.Format("{0:dd/MM/yyyy}", fact1.due_date);
            lblClienteOC.Text = fact1.cust_po_number;
            lblFacturaNum.Text = fact1.invoice_number_fiscal;
            DocsFiscales docs = new DocsFiscales();
            if (docs.RecuperarRegistro(DocsFiscales.DocType.Factura))
            {
                lblCAI.Text = "CAI: " + docs.CAI + "    Desde: " + string.Format("{0:dd/MM/yyyy}", docs.Desde) + "  Hasta: " + string.Format("{0:dd/MM/yyyy}", docs.Hasta);
                lblRangoAutorizado.Text = docs.RangoFrase;
            }
            lblLinea1.Text = fact1.aditional_line1;
            lblLinea2.Text = fact1.aditional_line2;
            lblLinea3.Text = fact1.aditional_line3;
            lblLinea4.Text = fact1.aditional_line4;
            lblLinea5.Text = fact1.aditional_line5;
            lblLinea6.Text = fact1.aditional_line6;

            lblCondicionPago.Text = fact1.Credit_term_description;
            lblDiasCredito.Text = fact1.credit_days.ToString() + " dias";
            ConversorNumALetras LPS_NUMS = new ConversorNumALetras(fact1.TotalFacturaUSD * fact1.TasaCambio);
            lblTotalwordsHNL.Text = LPS_NUMS.NumeroEnLetras;

            ConversorNumALetrasDolares UDS_Nums = new ConversorNumALetrasDolares(fact1.TotalFacturaUSD);
            lblTotalwordsUSD.Text = UDS_Nums.NumeroEnLetras;
            lblTasaCambio.Text = string.Format("{0:###,##0.0000}", fact1.TasaCambio);
            if (fact1.TotalISV > 0)
                lblSubGravado.Text = string.Format("{0:###,##0.000}", fact1.TotalFacturaUSD - fact1.TotalISV);
            else
                lblSubGravado.Text = "0.00";
            lblSub.Text = string.Format("{0:###,##0.000}", fact1.TotalFacturaUSD - fact1.TotalISV);
            lblISV.Text = string.Format("{0:###,##0.000}", fact1.TotalISV);
            lblTotalUSD.Text = string.Format("{0:###,##0.000}", fact1.TotalFacturaUSD);
            lblTotalLPS.Text = string.Format("{0:###,##0.000}", fact1.TotalFacturaUSD * fact1.TasaCambio);

            lblId_SAG.Text = fact1.ID_SAG;
            lblNumRegExonerado.Text = fact1.RegistroExoneradoC;
            lblOCCliente.Text = fact1.OC_Exenta;
            //lblLinea1.Text = fact1.aditional_line1;
            //LoadDetalle();

        }

        private void LoadDetalle(int pIdFactura)
        {
            
        }
    }
}
