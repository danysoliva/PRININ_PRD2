using DevExpress.XtraReports.UI;
using PRININ.Classes;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace PRININ.RPTS
{
    public partial class RPT_Retencion_ : DevExpress.XtraReports.UI.XtraReport
    {
        public RPT_Retencion_(int id, int id_datos_fiscales)
        {
            InitializeComponent();

            DBOperations dp = new DBOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
            {
                cnx.Open();

                dsRetencion1.rpt_retencion_h.Clear();

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_rpt_get_retencion_h_V2", cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

                da.Fill(dsRetencion1.rpt_retencion_h);


                cnx.Close();

            }


            //Detalle Retencion
            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
            {
                cnx.Open();

                dsRetencion1.retencion_d.Clear();

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_rpt_get_retencion_d_by_id_V2", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

                da.Fill(dsRetencion1.retencion_d);

                cnx.Close();

            }

            //Datos Numeracion Fiscal
            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
            {
                cnx.Open();

                dsRetencion1.datos_numeracion_fiscal.Clear();

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_datos_numeracion_fiscal", cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id_datos_fiscales;

                da.Fill(dsRetencion1.datos_numeracion_fiscal);

                cnx.Close();

            }
        }

        private void xrLabel28_BeforePrint(object sender, CancelEventArgs e)
        {
            try
            {
                DateTime Datetime1 = Convert.ToDateTime(xrLabel28.Text);
                xrLabel28.Text = string.Format("{0:MM/dd/yyyy}", Datetime1);
            }
            catch 
            {
            }
        }
    }
}
