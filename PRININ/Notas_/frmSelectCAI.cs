using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PRININ.Classes;
using PRININ.Notas;
using DevExpress.XtraGrid.Views.Grid;

namespace PRININ.Notas
{
    public partial class frmSelectCAI : Form
    {
        int idCai;
        public string CaiPar;
        public string correl;
        public string OtrasFact;
        public frmSelectCAI()
        {
            InitializeComponent();
            LoadCai();

            
        }

        private void LoadCai()
        {
            string sql = @"SELECT [id]
                                 ,[cai]
                                 ,[fecha_emision]
                                 ,[fecha_vence]
                                 ,[num_ini]
                                 ,[num_fin]
                                 ,CASE WHEN estado = 'i' THEN 'Inactivo'
	                             ELSE 'Activo'
	                             END as 'estado'
                            FROM [dbo].[z_INVREGDAT]
                                   WHERE kind = 'FA'
                                         and estado = 'a'";
            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNotas.selectCai.Clear();
                adat.Fill(dsNotas.selectCai);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void txtCorrelativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                CajaDialogo.Error("Solo se permiten numeros!");
                e.Handled = true;
                return;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsNotas.selectCaiRow)gridview.GetFocusedDataRow();

            try
            {
                CaiPar = row.cai;
                txtCorrelativo.Focus();
            }
            catch (Exception ex)
            {
                idCai = 0;
            }

        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            if (txtCorrelativo.Text == "")
            {
                CajaDialogo.Error("Numero de factura vacia.");
                return;
            }
            if (txtCorrelativo.Text.Length <= 7)
            {
                CajaDialogo.Error("El correlativo debe tener 8 digitos.");
                return;
            }
            //if (txtFactura.Enabled == true)
            //{
                
            //}

            OtrasFact = txtFactura.Text;

            correl = label1.Text + txtCorrelativo.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkBoxFAC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFAC.Checked)
            {
                txtFactura.Enabled = true;
            }
            else
            {
                txtFactura.Enabled = false;
                txtFactura.Clear();
            }
        }
    }
}
