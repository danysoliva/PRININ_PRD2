using DevExpress.XtraGrid.Views.Grid;
using PRININ.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRININ.Compras
{
    public partial class frmBuscarCliente : Form
    {
        string _pro_codigo;
        string _pro_nombre;
        string _pro_rtn;

        public string Pro_codigo { get => _pro_codigo; set => _pro_codigo = value; }
        public string Pro_nombre { get => _pro_nombre; set => _pro_nombre = value; }
        public string Pro_rtn { get => _pro_rtn; set => _pro_rtn = value; }

        public frmBuscarCliente()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string sql = @"SELECT OKCUNO as codigo,
                                        [OKCUNM] as nombre,
	                                    OKVRNO as rtn
                                    FROM [dbo].[OCUSMA]
                                    WHERE OKCUNO LIKE '321%' --321 es el codigo de compañia PROMIX
                                order by 2 asc ";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.proveedores.Clear();
                adat.Fill(dsCompras1.proveedores);
                conn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridMain.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();
            Pro_codigo = row["codigo"].ToString();
            Pro_nombre = row["nombre"].ToString();
            Pro_rtn = row["rtn"].ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
