using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRININ.Compras
{
    public partial class frmOrdenesC : Form
    {
        public frmOrdenesC()
        {
            InitializeComponent();
        }

        private void cmdOrdeneExenta_Click(object sender, EventArgs e)
        {
            frmOrdenCompraNormalResumen frm = new frmOrdenCompraNormalResumen();
            frm.Show();
        }

        private void cmdOrdeneExoneradas_Click(object sender, EventArgs e)
        {
            frmOrdenesCompraResumen frm = new frmOrdenesCompraResumen();
            frm.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
