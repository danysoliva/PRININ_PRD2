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

namespace PRININ.Retencion
{
    public partial class xfrmCAIProveedoresAdmin : DevExpress.XtraEditors.XtraForm
    {
        public xfrmCAIProveedoresAdmin()
        {
            InitializeComponent();
            load_data();
        }

    private void load_data()
    {
        try
        {
            DBOperations dp = new DBOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
            {
                cnx.Open();

                dsRetencion.Proveedor.Clear();

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_proveedores_V2", cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                da.Fill(dsRetencion.Proveedor);

                cnx.Close();

            }
        }
        catch (Exception ex)
        {
            CajaDialogo.Error(ex.Message);
        }
    }
    }
}