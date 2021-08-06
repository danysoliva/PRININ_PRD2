using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRININ.RPTS;
using DevExpress.XtraReports.UI;

namespace PRININ
{
    public partial class frmListadoChequesEmitidos : DevExpress.XtraEditors.XtraForm
    {
        public frmListadoChequesEmitidos()
        {
            InitializeComponent();
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            string fechaini;
            string fechafin;
            fechaini = String.Format("{0:yyyy-MM-dd}", dtDesde.EditValue);
            fechafin = String.Format("{0:yyyy-MM-dd}", dtHasta.EditValue);
            rptChequesEmitidos report = new rptChequesEmitidos(fechaini, fechafin);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }
    }
}