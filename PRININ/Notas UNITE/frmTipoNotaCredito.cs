using DevExpress.XtraEditors;
using PRININ.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRININ.Notas_UNITE
{
    public partial class frmTipoNotaCredito : DevExpress.XtraEditors.XtraForm
    {
        int FactId;
        DateTime FechaDocumento;
        int IdNota;
        public frmTipoNotaCredito(int pFact_id, DateTime pFechaDocumento, int pIdNota, string pConcepto)
        {
            InitializeComponent();
            FechaDocumento = pFechaDocumento;
            FactId = pFact_id;
            IdNota = pIdNota;
            txtConcepto.Text = pConcepto;

            FacturaH fact = new FacturaH();
            if (fact.RecuperarRegistro(FactId))
            {
                spinEdit1.Value = fact.TotalFacturaUSD;
            }
        }

        public string CodeWindow { get { return "WD0002"; } }

        private void LoadLineas()
        {
            try
            {
                string sql = @"[sp_get_detalles_factura_para_notas_credito]";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", FactId);
                dsNotasUNITE1.detalle_nota.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsNotasUNITE1.detalle_nota);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }



        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)//Si es de articulos
            {
                gridControl1.Enabled = true;
                LoadLineas();
            }
            else
            {
                gridControl1.Enabled = false;
            }
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

            if (dateFechaVence.DateTime < FechaDocumento)
            {
                CajaDialogo.Error("La fecha de vencimiento no puede ser menor que la fecha de la Nota!");
                return;
            }

            if (toggleSwitch1.IsOn)//Si es de articulos
            {
                //Validar que no hayan lineas con # de cuentas vacios
                //var gridView = (GridView)gridControl1.FocusedView;
                //var row = (dsMensualidades.mensualidadesRow)gridView.GetFocusedDataRow();
                foreach (dsNotasUNITE.detalle_notaRow row in dsNotasUNITE1.detalle_nota.Rows)
                {
                    if(row.cuenta == null)
                    {
                        CajaDialogo.Error("Debe ingresar el # de cuenta en cada linea de detalle de la Nota!");
                        return;
                    }
                }
            }
            //else
            //{
            //    gridControl1.Enabled = false;
            //}


            try
            {
                string sql = @"sp_insert_note_lines";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                foreach (dsNotasUNITE.detalle_notaRow row in dsNotasUNITE1.detalle_nota.Rows)
                {   
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_nota", IdNota);
                    cmd.Parameters.AddWithValue("@id_invoice_line", row.id);
                    cmd.Parameters.AddWithValue("@cuenta", row.cuenta);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }
    }
}