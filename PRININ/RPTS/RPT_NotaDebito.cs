using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PRININ.RPTS
{
    public partial class RPT_NotaDebito : DevExpress.XtraReports.UI.XtraReport
    {
        public RPT_NotaDebito(string cai, DateTime fchlimite, string numini, string numfin, 
                                string numdoc, DateTime fchcr, string codcliente, string cliente, string rtn, 
                                string monto, string montoletras, string concepto)
        {
            InitializeComponent();
            lblcai.Text = cai;
            lblfchlim.Text = Convert.ToString(fchlimite);
            lblnumini.Text = numini;
            lblnumfin.Text = numfin;
            lbldoc.Text = numdoc;
            lblfchcr.Text = Convert.ToString(fchcr);
            lblcodcliente.Text = codcliente;
            lblcliente.Text = cliente;
            lblrtn.Text = rtn;

            decimal debito = Convert.ToDecimal(monto);
            lblmonto.Text = string.Format("{0:#,###,##0.00}", debito);
            lblmontoletras.Text = Convert.ToString(montoletras);
            lblconcepto.Text = concepto;
        }
    }
}
