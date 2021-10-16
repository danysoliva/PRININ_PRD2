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

namespace PRININ.Mantenimiento.Resolucion_Fiscal
{
    public partial class frmMantoResolucion : DevExpress.XtraEditors.XtraForm
    {
        public frmMantoResolucion(Users pUser)
        {
            InitializeComponent();
            LoadResoluciones();
        }

        public string CodeWindow { get { return "WD0002"; } }

        private void LoadResoluciones()
        {
            try
            {
                string sql = @"sp_get_lista_resoluciones_f";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idnote", row.id);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsResolucion1.crud_res.Clear();
                adat.Fill(dsResolucion1.crud_res);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

    }
}