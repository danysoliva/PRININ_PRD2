using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PRININ.Classes;
using PRININ.Mantenimiento.Resolucion_Fiscal;
using PRININ.Mantenimiento.Resolucion_Fiscal.Model;
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
        Users UsuarioLogeado;
        public frmMantoResolucion(Users pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
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

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            xfrmResolucionFiscalCRUD frm = new xfrmResolucionFiscalCRUD(null,1);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadResoluciones();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void gridLookUpEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //gridLookUpEdit1
        }

        private void gridLookUpEdit1View_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            GridView gridView = sender as GridView;

            try
            {


                ResolucionFiscal resolucionFiscal = new ResolucionFiscal();

                if (e.Column.Caption == "Editar")
                {
                    resolucionFiscal.ID= Convert.ToInt32(gridView.GetFocusedRowCellValue(colID).ToString());
                    resolucionFiscal.Descripcion = gridView.GetFocusedRowCellValue(colDescripcion).ToString();
                    resolucionFiscal.Codigo=Convert.ToInt32( gridView.GetFocusedRowCellValue(colCodigo).ToString());
                    resolucionFiscal.FechaInicio = Convert.ToDateTime(gridView.GetFocusedRowCellValue(colFechaInicial).ToString());
                    resolucionFiscal.FechaFin = Convert.ToDateTime(gridView.GetFocusedRowCellValue(colFechaFinal).ToString());

                    xfrmResolucionFiscalCRUD form = new xfrmResolucionFiscalCRUD(resolucionFiscal, 2);

                    if (form.ShowDialog()== DialogResult.OK)
                    {
                        LoadResoluciones();
                    }
                }


                if (e.Column.Caption=="Eliminar")
                {
                    if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        try
                        {
                            DBOperations dp = new DBOperations();
                            SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringPRININ);


                            using (SqlCommand command = new SqlCommand("dbo.sp_update_estado_resolucion_fiscal", dbConnection))
                            {
                                dbConnection.Open();
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(gridView.GetFocusedRowCellValue(colID).ToString());

                                command.ExecuteNonQuery();
                                dbConnection.Close();

                                LoadResoluciones();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LoadDetalleCaps();
        }

        private void LoadDetalleCaps()
        {
            try
            {
                int idRes = Convert.ToInt32(gridLookUpEdit1.EditValue);
                string sql = @"sp_get_detalle_saldos_resolucion_manto";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_resolucion", idRes);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsResolucion1.resolucion_detalle.Clear();
                adat.Fill(dsResolucion1.resolucion_detalle);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gridLookUpEdit1.Text))
                return;

            int idres = Convert.ToInt32(gridLookUpEdit1.EditValue);
            frmNewCapitulo frm = new frmNewCapitulo(idres, gridLookUpEdit1.Text);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                //LoadResoluciones();
            }
        }
    }
}