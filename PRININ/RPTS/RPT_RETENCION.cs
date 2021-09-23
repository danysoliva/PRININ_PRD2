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
    public partial class RPT_RETENCION : DevExpress.XtraReports.UI.XtraReport
    {
        public RPT_RETENCION(int id)
        {
            InitializeComponent();

            DBOperations dp = new DBOperations();

            using (SqlConnection cnx= new SqlConnection(dp.ConnectionStringPRININ))
            {
                cnx.Open();

              dsRetencion1.rpt_retencion_h.Clear();

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_rpt_get_retencion_h", cnx);
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

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_rpt_get_retencion_d_by_id", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

                da.Fill(dsRetencion1.retencion_d);

                cnx.Close();

            }
        }

    }
}
