using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRININ.Retencion
{
    public partial class xfrmRetencionNew : DevExpress.XtraEditors.XtraForm
    {
        Users usuarioLogueado;


        public xfrmRetencionNew(Users puser)
        {
            InitializeComponent();
            gvRetencion.IndicatorWidth = 30;
            usuarioLogueado = puser;
            load_data();
        }

          //IndicatorWidth = 30; 
        private void gvRetencion_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle+1).ToString();
        }

        private void gvRetencion_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gvRetencion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            try
            {
                var row = (dsRetencion.retencion_dRow)gvRetencion.GetFocusedDataRow();

                if (e.Column.FieldName=="base_disponible")
                {

                    row.importe_total_retenido = row.base_disponible * (row.porcentaje_retencion/100);

                }

                if (e.Column.FieldName == "porcentaje_retencion")
                {

                    row.importe_total_retenido = row.base_disponible * (row.porcentaje_retencion / 100);

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                view.DeleteSelectedRows();
                e.Handled = true;
            }
        }

        SqlTransaction transaction;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( deFecha.Text))
            {
                CajaDialogo.Error("DEBE SELECCIONAR UNA FECHA DE EMISION");
                return;

            }

            if (string.IsNullOrEmpty(slueProveedor.Text))
            {
                CajaDialogo.Error("DEBE SELECCIONAR UN PROVEEDOR");
                return;

            }

            if (string.IsNullOrEmpty(txtCAI.Text))
            {
                CajaDialogo.Error("DEBE INGRESAR EL CAI");
                return;

            }

            if (string.IsNullOrEmpty(txtNumFiscal.Text))
            {
                CajaDialogo.Error("DEBE SELECCIONAR LA NUMERACIÓN FISCAL");
                return;
            }

            DBOperations dp = new DBOperations();

            SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ);

            try
            {
               

                cnx.Open();



                SqlCommand cmdCorrelative = new SqlCommand("dbo.sp_get_ultimo_correlativo_retenciones", cnx);
                cmdCorrelative.CommandType = CommandType.StoredProcedure;

                int ultimo_correlativo = Convert.ToInt32(cmdCorrelative.ExecuteScalar());


                transaction = cnx.BeginTransaction();

                SqlCommand cmd = new SqlCommand("dbo.sp_insert_retencion_h_V2", transaction.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;

                cmd.Parameters.Add("@id_proveedor", SqlDbType.NVarChar).Value = slueProveedor.EditValue;
                cmd.Parameters.Add("@fecha_creacion", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@fecha_emision", SqlDbType.DateTime).Value = deFecha.EditValue;
                cmd.Parameters.Add("@numero_fiscal", SqlDbType.VarChar).Value = txtNumFiscal.Text;
                cmd.Parameters.Add("@cai", SqlDbType.VarChar).Value =txtCAI.Text;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value =  usuarioLogueado.UserId;
                cmd.Parameters.Add("@ultimo_correlativo", SqlDbType.Int).Value =  ultimo_correlativo;
                cmd.Parameters.Add("@total", SqlDbType.Int).Value = Convert.ToDecimal(colimporte_total_retenido.Summary[0].SummaryValue.ToString());

                int id_inserted=Convert.ToInt32 ( cmd.ExecuteScalar());

                int count = 1; 
                foreach (var item in dsRetencion.retencion_d)
                {
                    SqlCommand cmd2 = new SqlCommand("dbo.sp_insert_retencion_d", transaction.Connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Transaction = transaction;

                    cmd2.Parameters.Add("@id_h", SqlDbType.Int).Value = id_inserted;
                    cmd2.Parameters.Add("@correlativo", SqlDbType.Int).Value = count;
                    cmd2.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = item.descripcion;
                    cmd2.Parameters.Add("@base_disponible", SqlDbType.Decimal).Value = item.base_disponible;
                    cmd2.Parameters.Add("@porcentaje_retencion", SqlDbType.Decimal).Value = item.porcentaje_retencion;
                    cmd2.Parameters.Add("@importe_total_retenido", SqlDbType.Decimal).Value = item.importe_total_retenido;

                    cmd2.ExecuteNonQuery();


                    count++;
                }

                transaction.Commit();
                cnx.Close();

                CajaDialogo.Information("DATOS GUARDADOS");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
            }
        }

        private void GuardarDatos()
        {

        }

        private void slueProveedor_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}