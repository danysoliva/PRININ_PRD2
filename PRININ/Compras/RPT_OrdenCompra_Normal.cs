using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PRININ.Compras
{
    public partial class RPT_OrdenCompra_Normal : DevExpress.XtraReports.UI.XtraReport
    {
        public RPT_OrdenCompra_Normal(string pNumero, decimal ptotal, decimal pimpuesto, decimal potros)
        {
            InitializeComponent();
            lblNumeroOrden.Text = pNumero;
            lblSub.Text = string.Format("{0:###,##0.00}", ptotal);
            lblIsv.Text = string.Format("{0:###,##0.00}", pimpuesto);
            lblOtros.Text = string.Format("{0:###,##0.00}", potros);
            
            lblTotal.Text = (ptotal + pimpuesto + potros).ToString();

            //string ttotal = (ptotal + pimpuesto).ToString();

            //lblTotal.Text = string.Format("{0:###,##0.00}", ttotal);
        }

    }
}
