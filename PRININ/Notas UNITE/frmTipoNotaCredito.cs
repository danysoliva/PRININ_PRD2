using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
        public int IdSource;

        public frmTipoNotaCredito(int pFact_id, DateTime pFechaDocumento, int pIdNota, string pConcepto, decimal pMonto, int pIdSource)
        {
            InitializeComponent();
            FechaDocumento = pFechaDocumento;
            FactId = pFact_id;
            IdNota = pIdNota;
            txtConcepto.Text = pConcepto;
            IdSource = pIdSource;


            //FacturaH fact = new FacturaH();
            //if (fact.RecuperarRegistro(FactId))
            //{
            //    spinEdit1.Value = fact.TotalFacturaUSD;
            //}
            spinEdit1.Value = pMonto;
        }

        public string CodeWindow { get { return "WD0002"; } }

        private void LoadLineas()
        {
            try
            {
                string sql = @"";
                if (IdSource == 1)
                    sql = @"[sp_get_detalles_factura_para_notas_creditov2]";
                else
                    sql = @"[sp_get_detalles_factura_para_notas_creditov3]";

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
                txtCuenta.Enabled = false;
                LoadLineas();
            }
            else
            {
                gridControl1.Enabled = false;
                txtCuenta.Enabled = true;
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
                //foreach (dsNotasUNITE.detalle_notaRow row in dsNotasUNITE1.detalle_nota.Rows)
                //{
                //    if(row.cuenta == null)
                //    {
                //        CajaDialogo.Error("Debe ingresar el # de cuenta en cada linea de detalle de la Nota!");
                //        return;
                //    }
                //}
                try
                {
                    string sql = @"[sp_insert_note_linesv3]";
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
                        int id_detalle_fact = 0;
                        try
                        {
                            id_detalle_fact = row.id;
                        }
                        catch{}

                        if(id_detalle_fact == 0)
                            cmd.Parameters.AddWithValue("@id_invoice_line", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_invoice_line", row.id);

                        cmd.Parameters.AddWithValue("@cuenta", DBNull.Value);

                        cmd.Parameters.AddWithValue("@units", row.cantidad_u);
                        cmd.Parameters.AddWithValue("@kg", row.cantidad_kg);
                        cmd.Parameters.AddWithValue("@price", row.precio);
                        cmd.Parameters.AddWithValue("@total_line", row.total_linea);
                        cmd.Parameters.AddWithValue("@um", row.um);
                        cmd.Parameters.AddWithValue("@desc", row.descripcion);
                        cmd.Parameters.AddWithValue("@code", row.codigo);
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

                try
                {
                    string sql = @"sp_set_update_nota_with_account_and_obs";
                    DBOperations dp = new DBOperations();
                    //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                    string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", IdNota);
                    cmd.Parameters.AddWithValue("@cuenta", DBNull.Value);
                    cmd.Parameters.AddWithValue("@obs", memoObservaciones.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCuenta.Text))
                {
                    CajaDialogo.Error("Es necesario ingresar el # de cuenta!");
                    txtCuenta.Focus();
                    return;
                }

                try
                {
                    string sql = @"sp_set_update_nota_with_account_and_obs";
                    DBOperations dp = new DBOperations();
                    //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                    string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", IdNota);
                    cmd.Parameters.AddWithValue("@cuenta", txtCuenta.Text);
                    cmd.Parameters.AddWithValue("@obs", memoObservaciones.Text);
                    cmd.ExecuteNonQuery();
                    
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

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsNotasUNITE.detalle_notaRow)gridView.GetFocusedDataRow();
            decimal valor = 0;
            switch (e.Column.FieldName)
            {
                case "cantidad_kg":
                case "cantidad_u":
                case "precio":
                    switch (row.um)
                    {
                        case "MT":
                            valor = ((row.cantidad_kg / 1000) * row.precio);
                            break;
                        default:
                            valor = (row.cantidad_u * row.precio);
                            break;
                    }
                    row.total_linea = valor;
                    break;
                default:
                    break;
            }
        }
    }
}