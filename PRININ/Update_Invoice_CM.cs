using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using PRININ.Classes;
using System.Data;
using DevExpress.XtraSplashScreen;

namespace PRININ
{
    public partial class Update_Invoice_CM : DevExpress.XtraEditors.XtraForm
    {
        int invoice_id;
        DataTable data;
        DBOperations dp = new DBOperations();

        public Update_Invoice_CM(int invoice_id)
        {
            InitializeComponent();
            this.invoice_id = invoice_id;
        }

        private void Update_Invoice_CM_Load(object sender, EventArgs e)
        {
            try
            {
                #region Procedure Parameters

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@invoice_id", SqlDbType.Int));
                cmd.Parameters["@invoice_id"].Value = invoice_id;

                #endregion

                #region Procedure Execution

                data = dp.PRININ_Exec_SP_Get_Data("lcl_get_invoice_custom_lines_v3", cmd);

                #endregion

                txt_line1.Text = data.Rows[0]["line1"].ToString();
                txt_line2.Text = data.Rows[0]["line2"].ToString();
                txt_line3.Text = data.Rows[0]["line3"].ToString();
                txt_line4.Text = data.Rows[0]["line4"].ToString();
                txt_line5.Text = data.Rows[0]["line5"].ToString();
                txt_line6.Text = data.Rows[0]["line6"].ToString();
                txtConsignadoA.Text = data.Rows[0]["consignada_a"].ToString();
                txtVendidoA.Text = data.Rows[0]["vendida_a"].ToString();
                txtOrdenCompra.Text = data.Rows[0]["cust_po_number"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al leer los datos.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btn_accept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea modificar los registros?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
                {
                    #region Procedure Parameters

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@invoice_id", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@line1", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@line2", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@line3", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@line4", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@line5", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@line6", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@consignada_a", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@vendida_a", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@cust_po_number", SqlDbType.VarChar));

                    cmd.Parameters["@invoice_id"].Value = invoice_id;
                    cmd.Parameters["@line1"].Value = txt_line1.Text.ToString();
                    cmd.Parameters["@line2"].Value = txt_line2.Text.ToString();
                    cmd.Parameters["@line3"].Value = txt_line3.Text.ToString();
                    cmd.Parameters["@line4"].Value = txt_line4.Text.ToString();
                    cmd.Parameters["@line5"].Value = txt_line5.Text.ToString();
                    cmd.Parameters["@line6"].Value = txt_line6.Text.ToString();
                    cmd.Parameters["@consignada_a"].Value = txtConsignadoA.Text.ToString();
                    cmd.Parameters["@vendida_a"].Value = txtVendidoA.Text.ToString();
                    cmd.Parameters["@cust_po_number"].Value = txtOrdenCompra.Text.ToString();

                    #endregion

                    #region Procedure Execution

                    dp.PRININ_Exec_SP("lcl_update_invoice_custom_lines_v3", cmd);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();

                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al leer los datos.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}