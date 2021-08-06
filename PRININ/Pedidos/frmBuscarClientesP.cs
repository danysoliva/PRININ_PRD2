using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRININ.Classes;
using PRININ.Pedidos;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace PRININ.Pedidos
{
    public partial class frmBuscarClientesP : DevExpress.XtraEditors.XtraForm
    {
        string _pro_id;
        string _pro_codigo;
        string _pro_cliente;
        string _pro_direccion;
        string _pro_direccion2;
        string _pro_direccion3;
        string _pro_direccion4;

        public frmBuscarClientesP()
        {
            InitializeComponent();
            LoadClientes();
        }
        DBOperations dp = new DBOperations();

        public string Pro_codigo { get => _pro_codigo; set => _pro_codigo = value; }
        public string Pro_cliente { get => _pro_cliente; set => _pro_cliente = value; }
        public string Pro_direccion { get => _pro_direccion; set => _pro_direccion = value; }
        public string Pro_direccion2 { get => _pro_direccion2; set => _pro_direccion2 = value; }
        public string Pro_direccion3 { get => _pro_direccion3; set => _pro_direccion3 = value; }
        public string Pro_direccion4 { get => _pro_direccion4; set => _pro_direccion4 = value; }
        public string Pro_id { get => _pro_id; set => _pro_id = value; }

        private void LoadClientes()
        {
            string sql = @"SELECT 
                             [OKCUNO] as Codigo
                            ,[OKCUNM] as Cliente
                            ,[OKCUA1] as Direccion
                        ,[OKTOWN]+','+ OKCUA4 as cliente_direccion2
                            ,[OKCUA4] as cliente_direccion3
                        ,[OKCUA3] as cliente_direccion4
                        FROM [dbo].[OCUSMA]
                        order by OKCUNM ASC";
            DBOperations dp = new DBOperations();
            SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            dsPedidos.clientes.Clear();
            adat.Fill(dsPedidos.clientes);

            //gridMain.DataSource = dp.PRININ_GetSelectData(@"SELECT 
            //                                                  [OKCUNO] as Codigo
            //                                                  ,[OKCUNM] as Cliente
            //                                                  ,[OKCUA1] as Direccion
            //                                               ,[OKTOWN]+','+ OKCUA4 as cliente_direccion2
            //                                                  ,[OKCUA4] as cliente_direccion3
            //                                               ,[OKCUA3] as cliente_direccion4
            //                                              FROM [DM3SK].[dbo].[OCUSMA]
            //                                              order by OKCUNM ASC
            //                                              ").Tables[0];


        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridMain.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            //Pro_id = row["id"].ToString();
            Pro_codigo = row["Codigo"].ToString();
            Pro_cliente = row["Cliente"].ToString();
            Pro_direccion = row["Direccion"].ToString();
            Pro_direccion2 = row["cliente_direccion2"].ToString();
            Pro_direccion3 = row["cliente_direccion3"].ToString();
            Pro_direccion4 = row["cliente_direccion4"].ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();

            
        }
    }
}