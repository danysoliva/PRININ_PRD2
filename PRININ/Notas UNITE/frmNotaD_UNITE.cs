using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using POS_Gasolinera_v1._0;
using PRININ.Classes;
using PRININ.Notas_UNITE;
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
                
                string sql = @"[ft_get_resumen_notas_credito_debito_unite]";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@showClosed", show_closed);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsNotasUNITE1.notas_resumen.Clear();
                adat.Fill(dsNotasUNITE1.notas_resumen);
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
            //frmSelectCAI frmSelect = new frmSelectCAI();
            //if (frmSelect.ShowDialog() == DialogResult.OK)
            //{
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsNotasUNITE.notas_resumenRow)gridView.GetFocusedDataRow();

            if(string.IsNullOrEmpty(row.cliente))
            {
                CajaDialogo.Error("Es necesario vincular una factura para poder imprimir la Nota!\nHaga Click en la celda # Factura para poder crear el vinculo!");
                return;
            }

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
            string Obs = "";
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
                                ,coalesce(obs,'')as obs
                        FROM [dbo].[NOTAS]
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
                    Obs = dr.GetString(12);
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
                            FROM [dbo].[z_INVREGDAT]
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

            if (row.tipo_nota == 1)//Credito
            {
                Nota Note1 = new Nota();
                if (Note1.IsNotaArticulos(row.id))
                {
                    //Es de articulos

                    //Cargar detalle de articulos
                    try
                    {
                        string sql = @"sp_get_detalle_lineas_nota_credito";
                        DBOperations dp = new DBOperations();
                        //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                        string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                        SqlConnection conn = new SqlConnection(ConnectionString);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idnote", row.id);
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        dsNotasUNITE1.detalle_nota_print.Clear();
                        adat.Fill(dsNotasUNITE1.detalle_nota_print);
                        conn.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }

                    RPT_NC_Items report = new RPT_NC_Items(cai, NumDoc,
                                                                Fecha, titulo,
                                                                monto, codCliente,
                                                                row.cliente, RTN,
                                                                concepto, Leyenda,
                                                                fechai, ini,
                                                                fin, row.enable, TasaCambio, row.cai, row.num_fact, "", row.due_date, Obs)
                    { DataSource = dsNotasUNITE1, DataMember = "detalle_nota_print", ShowPrintMarginsWarning = false };
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(report);
                    report.ShowPrintMarginsWarning = false;
                    printReport.ShowPreview();
                }
                else
                {
                    //Es de Concepto
                    //Cargar detalle de articulos
                    try
                    {
                        string sql = @"sp_get_detalle_lineas_nota_credito_concepto";
                        DBOperations dp = new DBOperations();
                        //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                        string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                        SqlConnection conn = new SqlConnection(ConnectionString);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idnote", row.id);
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        dsNotasUNITE1.detalle_nota_print.Clear();
                        adat.Fill(dsNotasUNITE1.detalle_nota_print);
                        conn.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    //
                    RPT_NC_Concept report = new RPT_NC_Concept(cai, NumDoc,
                                                                Fecha, titulo,
                                                                monto, codCliente,
                                                                row.cliente, RTN,
                                                                concepto, Leyenda,
                                                                fechai, ini,
                                                                fin, row.enable, TasaCambio, row.cai, row.num_fact, "", row.due_date,Obs)
                    { DataSource = dsNotasUNITE1, DataMember = "detalle_nota_print", ShowPrintMarginsWarning = false };
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(report);
                    report.ShowPrintMarginsWarning = false;
                    printReport.ShowPreview();
                }






                //RPT_OrdenCompra report = new RPT_OrdenCompra(num, total) { DataSource = dsCompras1, DataMember = "oc_detalle", ShowPrintMarginsWarning = false };

            }
            else//Debito
            {
                RPT_ND report = new RPT_ND(cai, NumDoc,
                                                                Fecha, titulo,
                                                                monto, codCliente,
                                                                row.cliente, RTN,
                                                                concepto, Leyenda,
                                                                fechai, ini,
                                                                fin, row.enable, TasaCambio, row.cai, row.num_fact, "", row.due_date, Obs);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                report.ShowPrintMarginsWarning = false;
                printReport.ShowPreview();
            }
           // }

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
            var row = (dsNotasUNITE.notas_resumenRow)gridView.GetFocusedDataRow();

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
                var row = (dsNotasUNITE.notas_resumenRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row.enable)
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                    else
                        e.Appearance.BackColor = Color.FromArgb(207, 117, 132);
                }
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private string GetLastEight(string invoice_number)
        {
            if (invoice_number.Length < 8)
            {
                return "Error: 03";
            }

            String var = invoice_number;
            String Var_Sub = "";
            if (var != null & var != "")
            {
                int tam_var = var.Length;
                Var_Sub = var.Substring((tam_var - 8), 8);
            }
            return Var_Sub;
        }

        private void cmdSearchInvoice_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsNotasUNITE.notas_resumenRow)gridView.GetFocusedDataRow();

            if(row.unite_doc_num== null)
            {
                CajaDialogo.Error("Solo se puede aplicar a Notas generadas mediante UNITE!");
                return;
            }


            //CajaDialogo.Information("Go!");
            frmExploreFactura frm = new frmExploreFactura();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                FacturaH Fact = new FacturaH();
                if (Fact.RecuperarRegistro(frm.IdFactura))
                {
                    //**********NUMERO FISCAL ND Y NC***********-
                    //Generar numeracion Fiscal PRININ para el SAR
            
                    if (row.tipo_nota == 1)//Nota Crédito
                    {
                        frmTipoNotaCredito frm2 = new frmTipoNotaCredito(frm.IdFactura, row.fecha_doc, row.id, row.concepto);
                        if(frm2.ShowDialog() == DialogResult.OK)
                        {
                            row.due_date = frm2.dateFechaVence.DateTime;
                            row.obs = frm2.memoObservaciones.Text;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        frmDueDateND frm2 = new frmDueDateND();// (frm.IdFactura, row.fecha_doc, row.id, row.concepto);
                        if (frm2.ShowDialog() == DialogResult.OK)
                        {
                            row.due_date = frm2.dateFechaVence.DateTime;
                            row.obs = frm2.memoObservaciones.Text;
                        }
                        else
                        {
                            return;
                        }
                    }


                    if (string.IsNullOrEmpty(row.num_documento))
                    {
                        DocsFiscales docs = new DocsFiscales();
                        DocsFiscales.DocType TypeDoc;
                        if (row.tipo_nota == 1)
                            TypeDoc = DocsFiscales.DocType.NotaCredito;
                        else
                            TypeDoc = DocsFiscales.DocType.NotaDebito;

                        if (docs.RecuperarRegistro(TypeDoc))
                        {
                            row.num_documento = docs.Leyenda + GetLastEight(row.unite_doc_num);
                            row.cai = docs.CAI;
                            decimal valor_ = 0;
                            if (row.tipo_nota == 1)
                                valor_ = row.credito;
                            else
                                valor_ = row.debito;

                            ConversorNumALetras ConverLetras = new ConversorNumALetras(valor_);
                            row.monto_letras = ConverLetras.NumeroEnLetras;
                            row.id_doc_fiscal = docs.Id;
                        }
                    }

                    row.cliente = Fact.customer_long_name;
                    row.num_fact = Fact.invoice_number_fiscal;
                    row.cod_cliente = Fact.customer_code;
                    row.factura_id = Fact.Id;

                    //Update Nota
                    try
                    {
                        string sql = @"sp_update_note_with_invoice_foreign";
                        DBOperations dp = new DBOperations();
                        //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                        string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                        SqlConnection conn = new SqlConnection(ConnectionString);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", row.id);//Id note
                        cmd.Parameters.AddWithValue("@factura_id", row.factura_id);
                        cmd.Parameters.AddWithValue("@cod_cliente", row.cod_cliente);
                        cmd.Parameters.AddWithValue("@rtn", Fact.customer_rtn);
                        cmd.Parameters.AddWithValue("@cai", row.cai);
                        cmd.Parameters.AddWithValue("@num_documento", row.num_documento);
                        cmd.Parameters.AddWithValue("@monto_letras", row.monto_letras);
                        cmd.Parameters.AddWithValue("@id_docs_fiscal", row.id_doc_fiscal);
                        cmd.Parameters.AddWithValue("@duedate", row.due_date);
                        cmd.Parameters.AddWithValue("@obs", row.obs);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
            }
        }

        private void cmdDesvincular_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton Desvincular
            DialogResult r = CajaDialogo.Pregunta("Realmente desea desvincular la factura de ésta Nota?");
            if (r != DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsNotasUNITE.notas_resumenRow)gridView.GetFocusedDataRow();

            //Update Nota
            try
            {
                string sql = @"sp_set_disable_link_invoice_note";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);//Id note
                //cmd.Parameters.AddWithValue("@factura_id", row.factura_id);
                //cmd.Parameters.AddWithValue("@cod_cliente", row.cod_cliente);
                //cmd.Parameters.AddWithValue("@rtn", Fact.customer_rtn);
                //cmd.Parameters.AddWithValue("@cai", row.cai);
                //cmd.Parameters.AddWithValue("@num_documento", row.num_documento);
                //cmd.Parameters.AddWithValue("@monto_letras", row.monto_letras);
                //cmd.Parameters.AddWithValue("@id_docs_fiscal", row.id_doc_fiscal);
                row.cai = null;
                row.cod_cliente = null;
                row.cliente = null;
                row.num_documento = null;
                row.rtn = null;
                row.id_doc_fiscal = 0;
                row.factura_id = 0;
                row.num_fact = null;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
