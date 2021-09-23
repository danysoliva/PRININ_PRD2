using DevExpress.XtraEditors;
using PRININ.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRININ.Notas_UNITE
{
    public partial class frmDueDateND : DevExpress.XtraEditors.XtraForm
    {
        public frmDueDateND()
        {
            InitializeComponent();
        }

        private void pS_Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pS_ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateFechaVence.Text))
            {
                CajaDialogo.Error("Debe indicar la fecha de Vencimiento de la Nota!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}