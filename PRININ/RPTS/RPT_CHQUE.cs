using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PRININ.RPTS
{
    public partial class RPT_CHQUE : DevExpress.XtraReports.UI.XtraReport
    {
        public RPT_CHQUE(string pLeyenda, string pFecha, string pNombre, string pValor, string pLetras)
        {
            InitializeComponent();
            lblLeyenda.Text = pLeyenda;
            lblFecha.Text = pFecha;
            lblNombre.Text = pNombre;
            decimal val = Convert.ToDecimal(pValor);
            lblValor.Text = string.Format("{0:#,###,##0.00}", val);
            lblLetras.Text = pLetras;
        }

    }
}
