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

namespace PRININ.Notas
{
    public partial class RPTSNotasDC : Form
    {
        public RPTSNotasDC()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtFechaDesde.Text) || string.IsNullOrEmpty(dtFechaHasta.Text))
            {
                CajaDialogo.Error("Debe seleccionar un rango de fechas valido!");
                return;
            }
            if (string.IsNullOrEmpty(comboNota.Text))
            {
                CajaDialogo.Error("Debe seleccion el tipo de nota");
                return;
            }

            try
            {
                string sql = @"SELECT T0.[id]
                                  ,T0.[tipo_nota]
                                  ,T0.[fecha_cr]
                                  ,T0.[cai]
                                  ,T0.[cod_cliente]
                                  ,T0.[credito]
                                  ,T0.[debito]
                                  ,T0.[monto_letras]
                                  ,T0.[concepto]
                                  ,T0.[num_documento]
                                  ,T0.[enable]
                                  ,T0.[rtn]
                                  ,T0.[fecha_doc]
                                  ,T0.[id_doc_fiscal]
                                  ,T0.[tasa]
                                     ,T1.nombre
                              FROM [PRININ].[dbo].[NOTAS] T0 join dbo.TIPONOTA T1 on  T0.tipo_nota = t1.id
                              where T0.enable = 1 and T0.fecha_doc BETWEEN @desde and @hasta and T0.[tipo_nota] = @tipo_nota";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@desde", SqlDbType.DateTime).Value = dtFechaDesde.Text;
                cmd.Parameters.Add("@hasta", SqlDbType.DateTime).Value = dtFechaHasta.Text;
                if (comboNota.Text == "Nota de Debito")
                {
                    //Nota de Debito
                    cmd.Parameters.Add("@tipo_nota", SqlDbType.Int).Value = 2;
                }
                else
                {
                    //Nota de Credito
                    cmd.Parameters.Add("@tipo_nota", SqlDbType.Int).Value = 1;
                }
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNotas.rpts_notas.Clear();
                adat.Fill(dsNotas.rpts_notas);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                CajaDialogo.Error("No hay informacion que convertir a EXCEL!");
                return;
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    gridControl1.ExportToXlsx(dialog.FileName);
                }
            }
        }
    }
}
