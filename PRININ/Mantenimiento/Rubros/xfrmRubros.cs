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

namespace PRININ.Mantenimiento.Rubros
{
    public partial class xfrmRubros : DevExpress.XtraEditors.XtraForm
    {
        public xfrmRubros()
        {
            InitializeComponent();
            LoadRubros();
        }

        private void LoadRubros()
        {

            try
            {
                DBOperations dp = new DBOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_rubros", cnx);

                    dsRubros.Rubros.Clear();
                    da.Fill(dsRubros.Rubros);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DBOperations dp = new DBOperations();
                    SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringPRININ);


                    using (SqlCommand command = new SqlCommand("dbo.sp_update_estado_rubro", dbConnection))
                    {
                        dbConnection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(gvRubros.GetFocusedRowCellValue(colid).ToString());

                        command.ExecuteNonQuery();
                        dbConnection.Close();

                        LoadRubros();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                DBOperations dp = new DBOperations();

                var row = (dsRubros.RubrosRow)gvRubros.GetFocusedDataRow();

                xfrmRubrosCRUD frm = new xfrmRubrosCRUD(row.id,row.codigo,row.descripcion,2);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    LoadRubros();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            xfrmRubrosCRUD frm = new xfrmRubrosCRUD(0,0,null,1);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadRubros();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}