using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using PRININ.Classes;
using DevExpress.XtraGrid.Views.Grid;
using PRININ.RPTS;
using DevExpress.XtraReports.UI;
using POS_Gasolinera_v1._0;

namespace PRININ
{
    public partial class frmCheques : DevExpress.XtraEditors.XtraForm
    {
        DBOperations dp = new DBOperations();
        int Vmoneda;
        string code; 
        public frmCheques()
        {
          
            InitializeComponent();
            Monedas Money = new Monedas();
            dp = new DBOperations();

            if (toggleSwitch1.IsOn)
            {
                Vmoneda = 2;//Dolares
                code = Money.GenerarSiguienteCodigo(Vmoneda);
            }
            else
            {
                Vmoneda = 1;//Lempiras
                code = Money.GenerarSiguienteCodigo(Vmoneda);
            }txtNumero.Text = code;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Confirma que va a Guardar este cheque?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;
            int moneda = 0;
            
            if (toggleSwitch1.IsOn)
                moneda = 2;//Dolares
            else
                moneda = 1;//Lempira
            

            try
            {
                string sql = @"INSERT INTO [dbo].[CHEQPRO]
                                                           ([leyenda]
                                                           ,[nombre]
                                                           ,[fecha]
                                                           ,[monto]
                                                           ,[valor_letras]
                                                           ,[numero]
                                                           ,[concepto]
                                                           ,[moneda])
                                                     VALUES
                                                           ('" + txtleyenda.Text +
                                                           "', '" + txtNombre.Text +
                                                           "', '" + txtFecha.Text +
                                                           "', " + Convert.ToDecimal(txtValor.Text).ToString() +
                                                           ", '" + txtLetras.Text +
                                                           "', '" + txtNumero.Text + 
                                                           "', '" + txtConcepto.Text +
                                                           "', "  + moneda.ToString() + ");";
                Monedas mn = new Monedas();
                mn.UpdateCam(Vmoneda);
                dp.PRININ_DoSmallDBOperation(sql);
                MessageBox.Show("Cheque Guardado con Exito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCheques();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdImprimirCheque_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Click en Imprimir
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsCheques.chequesRow)gridView.GetFocusedDataRow();
            RPT_CHQUE report = new RPT_CHQUE(row.leyenda, row.fecha, row.nombre, row.monto.ToString(), row.valor_letras);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void frmCheques_Load(object sender, EventArgs e)
        {
            CargarCheques();
        }

        public void CargarCheques()
        {
            //cargar cheques
            try
            {
                dsCheques1.cheques.Clear();
                Monedas Money = new Monedas();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);

                string sql = @"SELECT [id]
                                      ,[leyenda]
                                      ,[nombre]
                                      ,[fecha]
                                      ,[monto]
                                      ,[valor_letras]
                                      ,[numero]
                                      ,[concepto]
                                      ,case when moneda = 2 then
	                                     'Dolares'
	                                   else
	                                     'Lempiras'
	                                   end as moneda
                               FROM [dbo].[CHEQPRO]
                               where nulo = 0
                               order by [id] desc";

                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(command);
                adat.Fill(dsCheques1.cheques);
                if (toggleSwitch1.IsOn)
                {
                    Vmoneda = 2;
                    code = Money.GenerarSiguienteCodigo(Vmoneda);
                }
                else
                {
                    Vmoneda = 1;
                    code = Money.GenerarSiguienteCodigo(Vmoneda);
                }
                txtNumero.Text = code;
                conn.Close();
            }
            catch (Exception ec)
            {
                //
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtleyenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtFecha.Focus();
        }

        private void txtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtNumero.Focus();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtNombre.Focus();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtValor.Focus();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    decimal val = Convert.ToDecimal(txtValor.Text);
                    ConversorNumALetras conv = new ConversorNumALetras(val);
                    txtLetras.Text = conv.NumeroEnLetras;
                }
                catch
                {
                    MessageBox.Show("Ingrese un valor Decimal Valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtLetras.Focus();
            }
        }

        private void txtLetras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtConcepto.Focus();
        }

        private void Button_Eliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        private void listadoDeChequesEmitidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoChequesEmitidos frm = new frmListadoChequesEmitidos();
            frm.ShowDialog();
        }

        private void Button_Eliminar_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsCheques.chequesRow)gridView.GetFocusedDataRow();

            DialogResult r = MessageBox.Show("Confirma que desea eliminar este Cheque?","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            try
            {
                string sql = @"UPDATE [dbo].[CHEQPRO]
                                   SET [nulo] = 1 
                                 WHERE id = " + row.id.ToString();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                CargarCheques();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Error", ec.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoDeSecuenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Correlativo Mc = new Mantenimiento_Correlativo();
            if (Mc.ShowDialog() == DialogResult.OK)
            {
                Monedas mn = new Monedas();
               
                txtNumero.Text = mn.GenerarSiguienteCodigo(Vmoneda);
            }
           

        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            Monedas Money = new Monedas();
            if (toggleSwitch1.IsOn)
            {
                Vmoneda = 2;
                code = Money.GenerarSiguienteCodigo(Vmoneda);
            }
            else
            {
                Vmoneda = 1;
                code = Money.GenerarSiguienteCodigo(Vmoneda);
            }
            txtNumero.Text = code;
        }
    }
}