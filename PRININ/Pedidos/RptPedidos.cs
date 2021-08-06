using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PRININ.Pedidos
{
    public partial class RptPedidos : DevExpress.XtraReports.UI.XtraReport
    {
        public RptPedidos(string pnumero, decimal ptotal)
        {
            InitializeComponent();
            lblOrdenNum.Text = pnumero;
            lblTotal.Text = string.Format("{0:###,##0.00}", ptotal);
            
        }

    }
}
