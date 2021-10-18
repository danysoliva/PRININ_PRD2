using DevExpress.XtraEditors;
using PRININ.Classes;
using PRININ.Mantenimiento.Rubros.Model;
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
    public partial class xfrmCapitulos : DevExpress.XtraEditors.XtraForm
    {
        public xfrmCapitulos()
        {
            InitializeComponent();
            LoadCapitulos();
        }

        private void gcCapitulo_Click(object sender, EventArgs e)
        {

        }

        private void LoadCapitulos()
        {

            try
            {
                DBOperations dp = new DBOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_capitulos_rubros", cnx);

                    dsRubros.Capitulo.Clear();
                    da.Fill(dsRubros.Capitulo);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                DBOperations dp = new DBOperations();
                Capitulo capitulo = new Capitulo();


                var row = (dsRubros.CapituloRow)gvCapitulo.GetFocusedDataRow();
                capitulo.Codigo = row.codigo_cap;
                capitulo.RubroID = row.id_rubro;
                capitulo.ID = row.id;
                capitulo.Descripcion = row.descripcion;

                xfrmCapituloCRUD frm = new xfrmCapituloCRUD(capitulo, 2);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadCapitulos();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DBOperations dp = new DBOperations();
                    SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringPRININ);

                    var row = (dsRubros.CapituloRow)gvCapitulo.GetFocusedDataRow();
                    using (SqlCommand command = new SqlCommand("dbo.sp_update_estado_capitulo_rubro", dbConnection))
                    {
                        dbConnection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                        command.ExecuteNonQuery();
                        dbConnection.Close();

                        LoadCapitulos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            xfrmCapituloCRUD frm = new xfrmCapituloCRUD(null, 1);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadCapitulos();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}