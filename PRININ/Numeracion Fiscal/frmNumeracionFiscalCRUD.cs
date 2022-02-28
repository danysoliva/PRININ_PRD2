using DevExpress.XtraEditors;
using PRININ.Classes;
using PRININ.Numeracion_Fiscal.Model;
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

namespace PRININ.Numeracion_Fiscal
{
    public partial class frmNumeracionFiscalCRUD : DevExpress.XtraEditors.XtraForm
    {
        Users usuarioLogueado;

        int tipo_transaccion;
        NumeracionFiscal numeracionFiscal = new NumeracionFiscal();

       public enum TipoTransaccion { 
            agregar=1,
            editar=2
        }

        public frmNumeracionFiscalCRUD(Users userLogin,int t_transaccion)
        {
            InitializeComponent();
            load_typedoc();
            usuarioLogueado = userLogin;

            tipo_transaccion = t_transaccion;
        }

        public frmNumeracionFiscalCRUD(Users userLogin, int t_transaccion,NumeracionFiscal pNumeracionFiscal)
        {
            InitializeComponent();
            usuarioLogueado = userLogin;

            tipo_transaccion = t_transaccion;
            numeracionFiscal = pNumeracionFiscal;
            load_typedoc();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            switch (tipo_transaccion)
            {
                case 1:
                    try
                    {
                        DBOperations dp = new DBOperations();

                        if (string.IsNullOrEmpty(txtCAI.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL CAI");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtNumIni.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL FORMATO DE NUMERACION INICIAL");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtNumFin.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL FORMATO DE NUMERACION FINAL");
                            return;
                        }

                        if (string.IsNullOrEmpty(deFechaEmision.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR LA FECHA DE EMISION");
                            return;
                        }

                        if (string.IsNullOrEmpty(deFechaVence.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR LA FECHA DE VENCIMIENTO");
                            return;
                        }

                        if (string.IsNullOrEmpty(luEstado.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR UN ESTADO");
                            return;
                        }

                        if (string.IsNullOrEmpty(lueTypeDoc.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR TIPO DE DOCUMENTO");
                            return;
                        }




                        int correlativo;
                        if (tsSecuencia.IsOn)
                        {
                            correlativo = Convert.ToInt32(txtNumIni.Text.Substring(11, 8));
                        }
                        else
                        {
                            correlativo = 0;
                        }


                       
                        using (SqlConnection cnx= new SqlConnection(dp.ConnectionStringPRININ))
                        {

                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.sp_insert_numeracion_fiscal", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@cai", SqlDbType.VarChar).Value = txtCAI.Text;
                            cmd.Parameters.Add("@fecha_emision", SqlDbType.DateTime).Value = deFechaEmision.EditValue;
                            cmd.Parameters.Add("@fecha_vence", SqlDbType.DateTime).Value = deFechaVence.EditValue;
                            cmd.Parameters.Add("@num_ini", SqlDbType.VarChar).Value = txtNumIni.Text;
                            cmd.Parameters.Add("@num_fin", SqlDbType.VarChar).Value = txtNumFin.Text;
                            cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = luEstado.EditValue;
                            cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd.Parameters.Add("@created_by", SqlDbType.VarChar).Value = usuarioLogueado.Alias;
                            cmd.Parameters.Add("@created_from", SqlDbType.VarChar).Value = DBNull.Value;
                            cmd.Parameters.Add("@kind", SqlDbType.VarChar).Value = DBNull.Value;
                            cmd.Parameters.Add("@gen_corr", SqlDbType.Bit).Value = tsSecuencia.EditValue;
                            cmd.Parameters.Add("@correlative", SqlDbType.Int).Value = correlativo;
                            cmd.Parameters.Add("@leyenda", SqlDbType.NVarChar).Value = txtNumIni.Text.Substring(0, 11);
                            cmd.Parameters.Add("@TypeDoc", SqlDbType.NVarChar).Value = lueTypeDoc.Text;

                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS GUARDADOS");

                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;

                    case 2:

                    try
                    {

                        if (string.IsNullOrEmpty(txtCAI.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL CAI");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtNumIni.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL FORMATO DE NUMERACION INICIAL");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtNumFin.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR EL FORMATO DE NUMERACION FINAL");
                            return;
                        }

                        if (string.IsNullOrEmpty(deFechaEmision.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR LA FECHA DE EMISION");
                            return;
                        }

                        if (string.IsNullOrEmpty(deFechaVence.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR LA FECHA DE VENCIMIENTO");
                            return;
                        }

                        if (string.IsNullOrEmpty(luEstado.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR UN ESTADO");
                            return;
                        }

                        if (string.IsNullOrEmpty(lueTypeDoc.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR TIPO DE DOCUMENTO");
                            return;
                        }
                        DBOperations dp = new DBOperations();


                        numeracionFiscal.CAI = txtCAI.Text;
                        numeracionFiscal.NumFin = txtNumFin.Text;
                        numeracionFiscal.NumIni= txtNumIni.Text;
                        numeracionFiscal.FechaEmision= Convert.ToDateTime( deFechaEmision.EditValue);
                        numeracionFiscal.FechaVence = Convert.ToDateTime(deFechaVence.EditValue);
                        numeracionFiscal.GenCorr    =  Convert.ToBoolean(     tsSecuencia.EditValue);
                        numeracionFiscal.TypeDoc = lueTypeDoc.Text;
                        numeracionFiscal.Estado  = luEstado.EditValue.ToString();
                        

                        int correlativo;
                        if (tsSecuencia.IsOn)
                        {
                            correlativo = Convert.ToInt32(txtNumIni.Text.Substring(11, 8));
                        }
                        else
                        {
                            correlativo = 0;
                        }


                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
                        {

                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("[dbo].[sp_update_numeracion_fiscal]", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@cai", SqlDbType.VarChar).Value = txtCAI.Text;
                            cmd.Parameters.Add("@fecha_emision", SqlDbType.DateTime).Value = deFechaEmision.EditValue;
                            cmd.Parameters.Add("@fecha_vence", SqlDbType.DateTime).Value = deFechaVence.EditValue;
                            cmd.Parameters.Add("@num_ini", SqlDbType.VarChar).Value = txtNumIni.Text;
                            cmd.Parameters.Add("@num_fin", SqlDbType.VarChar).Value = txtNumFin.Text;
                            cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = luEstado.EditValue;
                            cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd.Parameters.Add("@created_by", SqlDbType.VarChar).Value = usuarioLogueado.Alias;
                            cmd.Parameters.Add("@created_from", SqlDbType.VarChar).Value = DBNull.Value;
                            cmd.Parameters.Add("@kind", SqlDbType.VarChar).Value = DBNull.Value;
                            cmd.Parameters.Add("@gen_corr", SqlDbType.Bit).Value = tsSecuencia.EditValue;
                            cmd.Parameters.Add("@correlative", SqlDbType.Int).Value = correlativo;
                            cmd.Parameters.Add("@leyenda", SqlDbType.NVarChar).Value = txtNumIni.Text.Substring(0, 11);
                            cmd.Parameters.Add("@TypeDoc", SqlDbType.NVarChar).Value = lueTypeDoc.Text;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = numeracionFiscal.ID;

                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS GUARDADOS");

                            this.DialogResult = DialogResult.OK;
                            cnx.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
            }


        }

        
        private void frmNumeracionFiscalCRUD_Load(object sender, EventArgs e)
        {

            try
            {
                DataRow workRow = dsNumeracionFiscal.Estado.NewRow();
                workRow["id_estado"] = "i";
                workRow["descripcion"] = "Inactivo";
                dsNumeracionFiscal.Estado.Rows.Add(workRow);

                DataRow workRow2 = dsNumeracionFiscal.Estado.NewRow();
                workRow2["id_estado"] = "a";
                workRow2["descripcion"] = "Activo";
                dsNumeracionFiscal.Estado.Rows.Add(workRow2);

                if (tipo_transaccion==2)
                {
                    txtCAI.Text = numeracionFiscal.CAI;
                    txtNumFin.Text = numeracionFiscal.NumFin;
                    txtNumIni.Text = numeracionFiscal.NumIni;
                    deFechaEmision.EditValue = numeracionFiscal.FechaEmision;
                    deFechaVence.EditValue = numeracionFiscal.FechaVence;
                    tsSecuencia.EditValue = numeracionFiscal.GenCorr;
                    lueTypeDoc.Text = numeracionFiscal.TypeDoc;
                    luEstado.EditValue = numeracionFiscal.Estado;

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_typedoc()
        {
            try
            {
                DBOperations dp = new DBOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringPRININ))
                {
                    cnx.Open();

                    dsNumeracionFiscal.typedoc.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_typedoc", cnx);
                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    da.Fill(dsNumeracionFiscal.typedoc);

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