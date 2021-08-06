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
using DevExpress.XtraGrid.Views.Grid;

namespace PRININ.Pedidos
{
    public partial class frmAddProd : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dt;
        public frmAddProd()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            //Query que me muestr los productos 
            //string sql = @"SELECT [MMITNO] as numero_articulo
            //               ,[MMFUDS] as descripcion
            //                     ,0 as checkadd
            //                     ,0 as precio_unit
            //             FROM MITMAS";

            string sql = @"SELECT ROW_NUMBER() 
                           Over (order by MMITNO) as id
		                  ,MMITNO as numero_articulo
		                  ,MMFUDS  as descripcion
                          ,0 as checkadd
                          ,0 as precio_unit
		                    FROM MITMAS";
            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPedidos.addProducto.Clear();
                adat.Fill(dsPedidos.addProducto);
                conn.Close();

            }
            catch (Exception ex) 
            {
                CajaDialogo.Error(ex.Message);
            }
            
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            dt = dsPedidos.addProducto.Clone();
            foreach (DataRow item in dsPedidos.addProducto.Rows)
            {
                if (Convert.ToBoolean(item["checkadd"]))
                {
                    dt.Rows.Add(item.ItemArray);
                }
            }

            dt.AcceptChanges();

            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
             var GridView = (GridView)gridProductos.FocusedView;
            var row = (dsPedidos.addProductoRow)GridView.GetFocusedDataRow();

            if (e.Column.Name == "checkadd")
            {
                row.checkadd = Convert.ToBoolean(e.Value);
            }
            //if (Convert.ToBoolean(e.Value))
            //{
            //    foreach (DataRow item in dsPedidos.addProducto.Rows)
            //    {
            //        if (row.descripcion.ToString() == item["descripcion"].ToString())
            //        {
            //            item["checkadd"] = e.Value;
            //        }
            //    }
            //}
            //else
            //{
            //    foreach (DataRow item in dsPedidos.addProducto.Rows)
            //    {
            //        if (row.descripcion.ToString() == item["descripcion"].ToString())
            //        {
            //            item["checkadd"] = e.Value;
            //        }
            //    }
            //}
            //dt.AcceptChanges();
        }
    }
}