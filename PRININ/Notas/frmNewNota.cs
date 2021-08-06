using POS_Gasolinera_v1._0;
using PRININ.Classes;
using PRININ.Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRININ.Notas
{
    public partial class frmNewNota : Form
    {
        public enum TipoNota
        {
            Credit = 1,
            Debit = 2
        }

        TipoNota TipoNotaActual;
        int Id_doc_fiscal;
        public frmNewNota()
        {
            InitializeComponent();
            TipoNotaActual = TipoNota.Debit;
            LoadNumeracion();
            LoadFecha();
        }

        private void LoadFecha()
        {
            try
            {
                DBOperations dp = new DBOperations();
                dtFecha.EditValue = dp.Now();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadNumeracion()
        {
            string sql = @"SELECT [prefijo]
                                  ,[siguiente]
                              FROM [dbo].[conf_tables_id]";

            string sql2 = @"SELECT [id]
                                  ,[cai]
                              FROM [dbo].[z_INVREGDAT]
                              where estado = 'a'";
            switch (TipoNotaActual)
            {
                case TipoNota.Credit:
                    sql += @" where id = 5";
                    sql2 += @" and kind = 'NC'";
                    break;
                case TipoNota.Debit:
                    sql += @" where id = 4";
                    sql2 += @" and kind = 'ND'";
                    break;
            }
            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                string prefijo="";
                int id_next = 0;
                int id_doc_fiscal;
                string cai = "";

                if (dr.Read())
                {
                    prefijo = dr.GetString(0);
                    id_next = dr.GetInt32(1);
                }
                dr.Close();

                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {
                    Id_doc_fiscal = id_doc_fiscal = dr2.GetInt32(0);
                    cai = dr2.GetString(1);
                }
                dr2.Close();

                txtCai.Text = cai;
                string correlativo = id_next.ToString();
                while (correlativo.Length <= 8)
                {
                    correlativo = "0" + correlativo;
                }
                txtDocumento.Text = prefijo + "-"+ correlativo;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdAbrirBusqueda_Click(object sender, EventArgs e)
        {
            
        }

        private void LookCliente()
        {
            frmBuscarCliente frm = new frmBuscarCliente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodigoProveedor.Text = frm.Pro_codigo;
                txtProveedor.Text = frm.Pro_nombre;
                txtRTN.Text = frm.Pro_rtn;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConcepto.Focus();
            }
        }

        private void txtConcepto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTasaCambio.Focus();
            }
        }

        private void toggleTipoNota_Toggled(object sender, EventArgs e)
        {
            if (toggleTipoNota.IsOn)
                TipoNotaActual = TipoNota.Debit;
            else
                TipoNotaActual = TipoNota.Credit;

            LoadNumeracion();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //validaciones
            if (string.IsNullOrEmpty(txtCodigoProveedor.Text))
            {
                CajaDialogo.Error("Debe seleccionar un proveedor!");
                return;
            }

            if (string.IsNullOrEmpty(dtFecha.Text))
            {
                CajaDialogo.Error("Debe ingresar la fecha de emision del documento!");
                return;
            }

            decimal valor = 0;
            decimal tasa = 0;
            try
            {
                valor = Convert.ToDecimal(txtMonto.Text);
                tasa = Convert.ToDecimal(txtTasaCambio.Text);
            }
            catch{}

            if(valor <= 0)
            {
                CajaDialogo.Error("Debe ingresar un monto mayor a cero!");
                return;
            }

            if (tasa <= 0)
            {
                CajaDialogo.Error("Debe ingresar una tasa mayor a cero!");
                return;
            }

            //Guardar la nota
            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                string sql = @"INSERT INTO [dbo].[NOTAS]
                                        ([tipo_nota]
                                        ,[cai]
                                        ,[cod_cliente]
                                        ,[credito]
                                        ,[debito]
                                        ,[monto_letras]
                                        ,[concepto]
                                        ,[num_documento]
                                        ,[rtn]
                                        ,[fecha_doc]
                                        ,[id_doc_fiscal]
                                        ,[tasa])
                                    VALUES
                                        (@tipo_nota
                                        ,@cai
                                        ,@cod_cliente
                                        ,@credito
                                        ,@debito
                                        ,@monto_letras
                                        ,@concepto
                                        ,@num_documento
                                        ,@rtn
                                        ,@fecha_doc
                                        ,@id_doc_fiscal
                                        ,@tasa)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("tipo_nota", SqlDbType.Int).Value = Convert.ToInt32(TipoNotaActual);
                cmd.Parameters.Add("cai", SqlDbType.VarChar).Value = txtCai.Text;
                cmd.Parameters.Add("cod_cliente", SqlDbType.VarChar).Value = txtCodigoProveedor.Text;
                if (TipoNotaActual == TipoNota.Credit)
                {
                    cmd.Parameters.Add("credito", SqlDbType.Decimal).Value = Convert.ToDecimal(txtMonto.Text);
                    cmd.Parameters.Add("debito", SqlDbType.Decimal).Value = 0;
                }
                else
                {
                    cmd.Parameters.Add("credito", SqlDbType.Decimal).Value = 0;
                    cmd.Parameters.Add("debito", SqlDbType.Decimal).Value = Convert.ToDecimal(txtMonto.Text);
                }
                ConversorNumALetras conver = new ConversorNumALetras(valor);
                cmd.Parameters.Add("monto_letras", SqlDbType.VarChar).Value = conver.NumeroEnLetras;
                cmd.Parameters.Add("concepto", SqlDbType.VarChar).Value = txtConcepto.Text;
                cmd.Parameters.Add("num_documento", SqlDbType.VarChar).Value = txtDocumento.Text;
                cmd.Parameters.Add("rtn", SqlDbType.VarChar).Value = txtRTN.Text;
                cmd.Parameters.Add("fecha_doc", SqlDbType.Date).Value = dtFecha.Text;
                cmd.Parameters.Add("id_doc_fiscal", SqlDbType.Int).Value = Id_doc_fiscal;
                cmd.Parameters.Add("tasa", SqlDbType.Decimal).Value = tasa;
                //cmd.Parameters.Add("cliente", SqlDbType.Int).Value = txtProveedor.Text;

                cmd.ExecuteScalar();

                int id_seq = 0;
                switch (TipoNotaActual)
                {
                    case TipoNota.Credit:
                        id_seq = 5;
                        break;
                    case TipoNota.Debit:
                        id_seq = 4;
                        break;
                }
                string seq = @"UPDATE [dbo].[conf_tables_id]
                                   SET [siguiente] = [siguiente] + 1
                               WHERE id = " + id_seq;
                SqlCommand cmdseq = new SqlCommand(seq, conn);
                cmdseq.ExecuteNonQuery();
                conn.Close();

                CajaDialogo.Information("Documento Guardado con Exito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }//fin de la funcion guardar.

        private void txtTasaCambio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMonto.Focus();
            }
        }

        private void cmdAbrirBusq_Click(object sender, EventArgs e)
        {
            LookCliente();
        }
    }
}
