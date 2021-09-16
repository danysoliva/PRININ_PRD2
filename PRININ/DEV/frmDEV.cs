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

namespace PRININ.DEV
{
    public partial class frmDEV : DevExpress.XtraEditors.XtraForm
    {
        public frmDEV()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"SELECT [id]
                                    ,[invoice_number]
                                    ,[due_date]
                                    ,[invoice_date]
                                    ,[customer_code]
                                    ,[customer_long_name]
                                    ,[customer_rtn]
                                    ,[created_by]
                                    ,[created_date]
                                    ,[cust_po_number]
                                    ,[id_credit_term]
                                    ,[shipping_addess]
                                    ,[shipping_country]
                                    ,[record_ex]
                                    ,[credit_days]

                                    ,[id_currency]
                                    ,[exchange_rate]
                                FROM [dbo].[INV_HEADER]
                                where [invoice_number] = @codigo";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", textEdit1.Text + textEdit2.Text);
                DataTable table1 = new DataTable();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(table1);
                vGridControl1.DataSource = table1;

                sql = @"SELECT A.[id]
                              ,[id_invoice_header]
                              ,[number_of_units]
                              ,[number_of_kg]
                              ,[product_code]
                              ,[product_name]
                              ,[unit_price]
                              ,[discount]
                              ,[total_line]
                              ,[tax_amount]
                          FROM [dbo].[INV_DETAIL] A join
                               [dbo].[INV_HEADER] B on
	                           A.id_invoice_header = B.id
                        where B.[invoice_number] = @codigo";
                SqlCommand cmd2 = new SqlCommand(sql, conn);
                //cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@codigo", textEdit1.Text + textEdit2.Text);
                DataTable table2 = new DataTable();
                SqlDataAdapter adat2 = new SqlDataAdapter(cmd2);
                adat2.Fill(table2);
                vGridControl2.DataSource = table2;
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}