using DevExpress.XtraEditors;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRININ.Retencion
{
   
    public partial class xfrmRetencion : DevExpress.XtraEditors.XtraForm
    {

        Users usuarioLogueado;
        public xfrmRetencion(string ptema,Users puser)
        {
            InitializeComponent();
            usuarioLogueado = puser;
            load_data();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void load_data()
        {
            try
            {
                DBOperations dp = new DBOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
                {
                    cnx.Open();

                    dsRetencion.retencion.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("[dbo].[sp_get_retenciones_V2]", cnx);
                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    da.Fill(dsRetencion.retencion);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var row = (dsRetencion.retencionRow)gvRetencion.GetFocusedDataRow();

                if (row != null)
                {
                    if (row.enable == true)
                    {

                        RPTS.RPT_Retencion_ report = new RPT_Retencion_(row.id, row.id_z_INVREGDAT);


                        report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                        ReportPrintTool printReport = new ReportPrintTool(report);
                        report.ShowPrintMarginsWarning = false;
                        printReport.ShowPreview();
                    }
                else
                {
                    CajaDialogo.Error("Comprobante de retención anulado");
                }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdNueva_Click(object sender, EventArgs e)
        {
            xfrmRetencionNew frm = new xfrmRetencionNew(usuarioLogueado);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                load_data();
            }
        }

        private void btnAnular_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("ESTA SEGURO(A) DE ANULAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DBOperations dp = new DBOperations();
                    SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringPRININ);

                    var row = (dsRetencion.retencionRow)gvRetencion.GetFocusedDataRow();


                    if (row != null)
                    {

                        if (row.enable == true)
                        {

                            using (SqlCommand command = new SqlCommand("dbo.sp_anular_retencion", dbConnection))
                            {
                                dbConnection.Open();
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                                command.ExecuteNonQuery();
                                dbConnection.Close();

                                load_data();
                            }
                        }
                        else
                        {
                            CajaDialogo.Error("Comprobante de retención anulado");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void xfrmRetencion_Load(object sender, EventArgs e)
        {
           
        }
    }
}