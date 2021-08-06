using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PRININ.Compras;
using System.Data;

namespace PRININ.RPTS
{
    public partial class RPT_OrdenCompra : DevExpress.XtraReports.UI.XtraReport
    {
        public RPT_OrdenCompra(string pNumeroOrden, decimal pTotal, string presolucion)
        {
            InitializeComponent();
            lblNumeroOrden.Text = pNumeroOrden + presolucion; 
            lblTotal.Text = lblSub.Text = string.Format("{0:###,##0.00}", pTotal);
        }

        private void RPT_OrdenCompra_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
