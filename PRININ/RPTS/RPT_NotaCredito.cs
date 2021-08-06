using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PRININ.RPTS
{
    public partial class RPT_NotaCredito : DevExpress.XtraReports.UI.XtraReport
    {
        public RPT_NotaCredito(string cai, string fchlimite, string numini, string numfin,
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

            decimal credito = Convert.ToDecimal(monto);
            lblmonto.Text = string.Format("{0:#,###,##0.00}", credito);
            lblmontoletras.Text = Convert.ToString(montoletras);
            lblconcepto.Text = concepto;
        }

    }
}
