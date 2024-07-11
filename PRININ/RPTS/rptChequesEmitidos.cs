using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using System.Data.Sql;
using PRININ.Classes;
using System.Windows.Forms;

namespace PRININ.RPTS
{
    public partial class rptChequesEmitidos : DevExpress.XtraReports.UI.XtraReport

    {
        string fechainicial, fechafinal;
        public rptChequesEmitidos(string Fechaini, string fechafin)
        {
            InitializeComponent();
            DBOperations dp;

            try
            {
                dp = new DBOperations();
                fechainicial = Fechaini;
                fechafinal = fechafin;
                lblDesde.Text = fechainicial;
                lblHasta.Text = fechafinal;
                string Qry;
                Qry = @"Select nombre
						        ,monto
						        ,case when moneda = 2 then
						        'US $'
						        else
						        'Lps.'
						        end as moneda 
						        ,concepto
                                ,(SELECT CONVERT (varchar(15), fecha_cheque, 110)) as fecha_cheque
                                ,numero
				        from PRININ.dbo.CHEQPRO
				        where moneda = 1 and (nulo = 0 ) and
				        fecha_cheque between  '" + fechainicial + "' and " +
                        "'" + fechafinal + "' order by moneda ASC ";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringPRININ);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Qry, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCheques2.ChequesLempiras.Clear();
                da.Fill(dsCheques2.ChequesLempiras);

                string QryLps;
                QryLps = @"SELECT Sum(monto)
                                from PRININ.dbo.CHEQPRO
                                where moneda = 1  and (nulo = 0 ) and
				fecha_cheque between  '" + fechainicial + "' and " +
                "'" + fechafinal + "'";
                cmd = new SqlCommand(QryLps, cn);
               

                LbLempiras.Text = string.Format("{0: ###,##0.00}", Convert.ToDecimal(cmd.ExecuteScalar()));
                //cn.Close();

                string Qrydollar;
                Qrydollar = @"Select nombre
						,monto
						,case when moneda = 2 then
						'US $'
						else
						'Lps.'
						end as moneda 
						,concepto
                        ,(SELECT CONVERT (varchar(15), fecha_cheque, 110)) as fecha_cheque
                        ,numero
				from PRININ.dbo.CHEQPRO
				where moneda = 2 
				 and (nulo = 0 ) and
				fecha_cheque between  '" + fechainicial + "' and " +
                "'" + fechafinal + "'";
                cmd = new SqlCommand(Qrydollar, cn);
                SqlDataAdapter dax = new SqlDataAdapter(cmd);
                dsCheques1.ChequesDolar.Clear();
                dax.Fill(dsCheques1.ChequesDolar);
                QryLps = @"SELECT Sum(monto)
                                from PRININ.dbo.CHEQPRO
                                where moneda = 2  and (nulo = 0 ) and
				fecha_cheque between  '" + fechainicial + "' and " +
                "'" + fechafinal + "'";
                cmd = new SqlCommand(QryLps, cn);

                LblDolares.Text = string.Format("{0: ###,##0.00}", Convert.ToDecimal(cmd.ExecuteScalar()));


                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

            
        

        }

        private void rptChequesEmitidos_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        private void xrLabel13_BeforePrint(object sender, CancelEventArgs e)
        {
                    }
    }
}
