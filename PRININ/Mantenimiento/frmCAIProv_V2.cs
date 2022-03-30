using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PRININ.Classes;
using System.Data.SqlClient;
using PRININ.Mantenimiento;
using PRININ.Compras;

namespace PRININ.Mantenimiento
{
    public partial class frmCAIProv_V2 : Form
    {
        Users usuarioLogueado;
        string codProveedor;

        public frmCAIProv_V2(Users usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            LoadData();
            load_data();
        }


        public frmCAIProv_V2(Users usuario,string proveedorID)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            LoadData();
            load_data();
            codProveedor = proveedorID;
        }

        private void LoadData()
        {
            string sql = @"SELECT OKCUNO as codigo,
                                        [OKCUNM] as nombre,
	                                    OKVRNO as rtn
                                    FROM [dbo].[OCUSMA]
                                    WHERE OKCUNO LIKE '321%' --321 es el codigo de compañia PROMIX
                                order by 2 asc";
            DBOperations dp = new DBOperations();
            SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            dsMante.proveedores.Clear();
            adat.Fill(dsMante.proveedores);
            conn.Close();
        }

        private void cmdAddCai_Click(object sender, EventArgs e)
        {

            if (searchLookUpEdit1.EditValue==null)
            {
                CajaDialogo.Error("DEBE SELECCIONAR UN PROVEEDOR");
            }
            else
            {

            dsMante.cai_prov_V2Row row1 = dsMante.cai_prov_V2.Newcai_prov_V2Row();
            dsMante.cai_prov_V2.Addcai_prov_V2Row(row1);
            dsMante.AcceptChanges();
            }

        }

        private void repositoryItemDelete_Click(object sender, EventArgs e)
        {
            try
            {
            var row = (dsMante.cai_prov_V2Row)gvCAI.GetFocusedDataRow();
                DBOperations dp = new DBOperations();

            if (row!=null)
            {

                if (string.IsNullOrEmpty( row.cai) || string.IsNullOrEmpty(row.rango) || string.IsNullOrEmpty(row.fecha_limite.ToString()))
                {
                    CajaDialogo.Error("Hay campos vacios");
                    return;
                }
            else
            {

                        Boolean activar_desactivar;
                        string mensaje;

                        if (TSCai.IsOn==false)
                        {
                            activar_desactivar = true;
                            mensaje = "Esta seguro de activar este CAI?";
                        }
                        else
                        {
                            activar_desactivar = false;
                            mensaje = "Esta seguro de desactivar este CAI?";

                        }

                        DialogResult r = CajaDialogo.Pregunta(mensaje);
                        if (r == System.Windows.Forms.DialogResult.Yes)
                        {
                            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
                            {
                                cnx.Open();

                                SqlCommand cmd = new SqlCommand("dbo.sp_desactivar_cai_by_prv",cnx);

                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                                cmd.Parameters.Add("@activar_desactivar", SqlDbType.Bit).Value = activar_desactivar;

                                cmd.ExecuteNonQuery();

                                 gvCAI.DeleteRow(gvCAI.FocusedRowHandle);
                                cnx.Close();

                            }

                            LoadCAI(Convert.ToBoolean( TSCai.EditValue));

                        }


                        //var gridView1 = (DevExpress.XtraGrid.Views.Grid.GridView)gridControlCAI.FocusedView;
                        //var row = (dsMante.cai_provRow)gridView1.GetFocusedDataRow();
                    }
            }

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (gvCAI.DataRowCount == 0)
            {
                CajaDialogo.Pregunta("Se va guardar sin haber ingresado ningun CAI?");
                return;
            }

            //if (searchLookUpEdit1.Text == "")
            //{
            //    CajaDialogo.Error("Debe elegir un Proveedor");
            //    gridProv.Focus();
            //    return;
            //}
            //Validar que la informacion de los CAI no esta vacia
            for (int i = 0; i < gvCAI.DataRowCount; i++)
            {
                DataRow row = gvCAI.GetDataRow(i);
                if (row[1] != null)
                {
                    if (string.IsNullOrEmpty(row[3].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar en blanco!");
                    return;
                }
                if (row[2] != null)
                {
                    if (string.IsNullOrEmpty(row[3].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar en blanco!");
                    return;
                }
                if (row[3] != null)
                {
                    if (string.IsNullOrEmpty(row[3].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar en blanco!");
                    return;
                }

            }


            DBOperations dp = new DBOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringPRININ);

            cn.Open();
            foreach (var item in dsMante.cai_prov_V2)
            {
                using (SqlCommand cmd =  new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.sp_crud_cai_proveedor";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = item.id;
                    cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = usuarioLogueado.UserId;
                    cmd.Parameters.Add("@prv_key", SqlDbType.VarChar).Value = searchLookUpEdit1.EditValue;
                    cmd.Parameters.Add("@rango", SqlDbType.VarChar).Value = item.rango;
                    cmd.Parameters.Add("@CAI", SqlDbType.VarChar).Value = item.cai;
                    cmd.Parameters.Add("@fecha_limite", SqlDbType.DateTime).Value = item.fecha_limite;
                    cmd.Parameters.Add("@fecha_creado", SqlDbType.DateTime).Value = DateTime.Now ;


                    cmd.ExecuteNonQuery();

                }
            }

            cn.Close();

            if (!string.IsNullOrEmpty(codProveedor))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cmdAbrirBusqueda_Click(object sender, EventArgs e)
        {
            LookProveedor();                       
        }

        private void LookProveedor()
        {

        }

        private void load_data()
        {
            try
            {
                DBOperations dp = new DBOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
                {
                    cnx.Open();

                    dsMante.Proveedor.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_proveedores_V2", cnx);
                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    da.Fill(dsMante.Proveedor);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void LoadCAI(Boolean activo)
        {
            try
            {

                string sql = @"dbo.sp_get_cai_by_proveedor";
                var row = (dsMante.cai_prov_V2Row)gvCAI.GetFocusedDataRow();


                if (searchLookUpEdit1.EditValue != null)
                {

                    DBOperations dp = new DBOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@key_prov", SqlDbType.VarChar).Value = searchLookUpEdit1.EditValue;
                    cmd.Parameters.Add("@activo", SqlDbType.VarChar).Value = activo;

                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    dsMante.cai_prov_V2.Clear();
                    adat.Fill(dsMante.cai_prov_V2);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LoadCAI(Convert.ToBoolean( TSCai.EditValue));
        }

        private void frmCAIProv_V2_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(codProveedor))
            {
                searchLookUpEdit1.EditValue = codProveedor;
            }
        }

        private void TSCai_Toggled(object sender, EventArgs e)
        {
            LoadCAI(Convert.ToBoolean(TSCai.EditValue));
        }
    }
}
