using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using PRININ.Classes;
using PRININ.RPTS;
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
    public partial class frmNotaD_UNITE : Form
    {
        public frmNotaD_UNITE(string ptema)
        {
            InitializeComponent();
            LoadNotas();
        }
        public string CodeWindow { get { return "WD0002"; } }

        private void LoadNotas()
        {
            try
            {
                int show_closed = 0;
                if (tgMostrarCerradas.IsOn)
                    show_closed = 1;
                
                string sql = @"EXEC [dbo].[ft_get_resumen_notas_credito_debito] @showClosed = " + show_closed;
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNotas1.notas_resumen.Clear();
                adat.Fill(dsNotas1.notas_resumen);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Vamos a instanciar un formulario para elegir el CAI y el Correlativo del Comprobante
            frmSelectCAI frmSelect = new frmSelectCAI();
            if (frmSelect.ShowDialog() == DialogResult.OK)
            {
                    var gridView = (GridView)gridControl1.FocusedView;
                    var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();

                    int tipon = 0;
                    string cai = "";
                    string codCliente = "";
                    decimal credito = 0;
                    decimal TasaCambio = 0;
                    decimal debito = 0;
                    string montoL = "";
                    string concepto = "";
                    string NumDoc = "";
                    string RTN = "";
                    DateTime Fecha = DateTime.Now;
                    int ID_Doc_Fiscal = 0;
                    try
                    {
                        string sql = @"SELECT    [tipo_nota]
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
                                        ,[tasa]
                                FROM [PRININ].[dbo].[NOTAS]
                                WHERE id = " + row.id;
                        DBOperations dp = new DBOperations();
                    //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                    string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            tipon = dr.GetInt32(0);
                            cai = dr.GetString(1);
                            codCliente = dr.GetString(2);
                            credito = dr.GetDecimal(3);
                            debito = dr.GetDecimal(4);
                            montoL = dr.GetString(5);
                            concepto = dr.GetString(6);
                            NumDoc = dr.GetString(7);
                            RTN = dr.GetString(8);
                            Fecha = dr.GetDateTime(9);
                            ID_Doc_Fiscal = dr.GetInt32(10);
                            TasaCambio = dr.GetDecimal(11);
                        }
                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    string titulo = "";
                    decimal monto = 0;
                    string Evento = "";
                    switch (tipon)
                    {
                        case 1://credito
                            titulo = "NOTA DE CREDITO";
                            Evento = "ACREDITANDO";
                            monto = credito;
                            break;
                        case 2://debito
                            titulo = "NOTA DE DEBITO";
                            Evento = "DEBITANDO";
                            monto = debito;
                            break;
                    }
                    string Leyenda = "Por este medio le notificamos que le estamos " + Evento +
                                     " a su apreciable cuanta los valores antes mencionado por el siguiente concepto:";
                    DateTime fechai = DateTime.Now;
                    string ini = "";
                    string fin = "";


                    try
                    {
                        string sql = @"SELECT [fecha_vence]
                                      ,[num_ini]
                                      ,[num_fin]
                                  FROM [PRININ].[dbo].[z_INVREGDAT]
                                  where id = " + ID_Doc_Fiscal;
                        DBOperations dp = new DBOperations();
                    //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                    string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            fechai = dr.GetDateTime(0);
                            ini = dr.GetString(1);
                            fin = dr.GetString(2);
                        }
                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }

                    RPT_ND_NC_Local report = new RPT_ND_NC_Local(cai, NumDoc,
                                                                 Fecha, titulo,
                                                                 monto, codCliente,
                                                                 row.cliente, RTN,
                                                                 concepto, Leyenda,
                                                                 fechai, ini,
                                                                 fin, row.enable, TasaCambio, frmSelect.CaiPar, frmSelect.correl, frmSelect.OtrasFact);
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(report);
                    report.ShowPrintMarginsWarning = false;
                    printReport.ShowPreview();
                
            }

            #region codigo no usado
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();

            //int tipon = 0;
            //string cai = "";
            //string codCliente = "";
            //decimal credito = 0;
            //decimal TasaCambio = 0;
            //decimal debito = 0;
            //string montoL = "";
            //string concepto = "";
            //string NumDoc = "";
            //string RTN = "";
            //DateTime Fecha = DateTime.Now;
            //int ID_Doc_Fiscal = 0;
            //try
            //{
            //    string sql = @"SELECT    [tipo_nota]
            //                            ,[cai]
            //                            ,[cod_cliente]
            //                            ,[credito]
            //                            ,[debito]
            //                            ,[monto_letras]
            //                            ,[concepto]
            //                            ,[num_documento]
            //                            ,[rtn]
            //                            ,[fecha_doc]
            //                            ,[id_doc_fiscal]
            //                            ,[tasa]
            //                    FROM [PRININ].[dbo].[NOTAS]
            //                    WHERE id = " + row.id;
            //    DBOperations dp = new DBOperations();
            //    SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        tipon = dr.GetInt32(0);
            //        cai = dr.GetString(1);
            //        codCliente = dr.GetString(2);
            //        credito = dr.GetDecimal(3);
            //        debito = dr.GetDecimal(4);
            //        montoL = dr.GetString(5);
            //        concepto = dr.GetString(6);
            //        NumDoc = dr.GetString(7);
            //        RTN = dr.GetString(8);
            //        Fecha = dr.GetDateTime(9);
            //        ID_Doc_Fiscal = dr.GetInt32(10);
            //        TasaCambio = dr.GetDecimal(11);
            //    }
            //    dr.Close();
            //    conn.Close();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
            //string titulo = "";
            //decimal monto = 0;
            //string Evento = "";
            //switch (tipon)
            //{
            //    case 1://credito
            //        titulo = "NOTA DE CREDITO";
            //        Evento = "ACREDITANDO";
            //        monto = credito;
            //        break;
            //    case 2://debito
            //        titulo = "NOTA DE DEBITO";
            //        Evento = "DEBITANDO";
            //        monto = debito;
            //        break;
            //}
            //string Leyenda = "Por este medio le notificamos que le estamos " + Evento + 
            //                 " a su apreciable cuanta los valores antes mencionado por el siguiente concepto:";
            //DateTime fechai = DateTime.Now;
            //string ini="";
            //string fin = "";


            //try
            //{
            //    string sql = @"SELECT [fecha_emision]
            //                          ,[num_ini]
            //                          ,[num_fin]
            //                      FROM [PRININ].[dbo].[z_INVREGDAT]
            //                      where id = " + ID_Doc_Fiscal;
            //    DBOperations dp = new DBOperations();
            //    SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        fechai = dr.GetDateTime(0);
            //        ini = dr.GetString(1);
            //        fin = dr.GetString(2);
            //    }
            //    dr.Close();
            //    conn.Close();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}

            //RPT_ND_NC_Local report = new RPT_ND_NC_Local(cai, NumDoc,
            //                                             Fecha, titulo,
            //                                             monto, codCliente,
            //                                             row.cliente, RTN,
            //                                             concepto, Leyenda,
            //                                             fechai, ini,
            //                                             fin, row.enable, TasaCambio);
            //report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //ReportPrintTool printReport = new ReportPrintTool(report);
            //printReport.ShowPreview();

            #endregion
        }

        private void tgMostrarCerradas_Toggled(object sender, EventArgs e)
        {
            LoadNotas();
        }

        private void cmdNueva_Click(object sender, EventArgs e)
        {
            //Nueva Nota de Credito - Debito
            frmNewNota frm = new frmNewNota();
            if(frm.ShowDialog() == DialogResult.OK)
                LoadNotas();
            
        }

        private void btnAnular_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton Anular
            DialogResult r = CajaDialogo.Pregunta("Realmente desea anular esta Nota?");
            if(r != DialogResult.Yes)
                return;

            //Anular la nota
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();

            try
            {
                string sql = @"UPDATE [dbo].[NOTAS]
                                 SET [enable] = 0
                               WHERE id = " + row.id;
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                CajaDialogo.Information("Documento anulado con exito!");
                LoadNotas();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl1.FocusedView;
                //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
                var row = (dsNotas.notas_resumenRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row.enable)
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                    else
                        e.Appearance.BackColor = Color.FromArgb(207, 117, 132);
                }
            }
        }
    }
}
