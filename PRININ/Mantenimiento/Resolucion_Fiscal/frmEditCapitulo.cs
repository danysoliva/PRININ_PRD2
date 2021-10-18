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
    public partial class frmEditCapitulo : DevExpress.XtraEditors.XtraForm
    {
        int IdResolucion;
        int IdCapRow;
        int IdCapMaster;
        public frmEditCapitulo(int pIdRes, string ResDescripcion, int rub, int cap, int pIdCapMaster)
        {
            InitializeComponent();
            IdResolucion = pIdRes;
            IdCapRow = cap;
            IdCapMaster = pIdCapMaster;
            lblResolucion.Text = ResDescripcion;
            LoadRubros(pIdRes);
            grLookEdit_Rubro.EditValue = rub;
            LoadCaps(rub);
            grLookEdit_Capitulo.EditValue = cap;
            LoadSaldosSegunCap(pIdRes, cap);
        }

        public void LoadSaldosSegunCap(int pres, int pcap)
        {
            try
            {
                string queryval = "sp_get_duplicate_cap_from_resolution";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();

                SqlCommand cmdVal = new SqlCommand(queryval, conn);
                cmdVal.CommandType = CommandType.StoredProcedure;
                cmdVal.Parameters.AddWithValue("@idcap", pcap);
                cmdVal.Parameters.AddWithValue("@idres", pres);
                cmdVal.Parameters.AddWithValue("@idcap_master", IdCapMaster);
                SqlDataReader dr = cmdVal.ExecuteReader();
                if (dr.Read())
                {
                    string codigo = dr.GetString(2);
                    string descrip = dr.GetString(3);
                    decimal inicial = dr.GetDecimal(4);
                    decimal saldo = dr.GetDecimal(5);
                    decimal pagos = dr.GetInt32(6);

                    spinEditSaldoInicial.Value = inicial;
                    spinEditSaldoDisponible.Value = saldo;
                    spinEditPagos.EditValue = pagos;
                }
                dr.Close();
            }
            catch(Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadRubros(int pIdResolucionSelected)
        {
            try
            {
                string sql = @"sp_get_lista_rubros_data_master";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_res", pIdResolucionSelected);
                dsResolucion1.master_rubros.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsResolucion1.master_rubros);
                conn.Close();
                //this.grResolucion.Enabled = false;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        //sp_get_detalle_rubro_capitulos_master_date
        private void LoadCaps(int pidRubro_)
        {
            try
            {
                string sql = @"sp_get_detalle_rubro_capitulos_master_date";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@id_rubro", pidRubro_);
                dsResolucion1.master_caps.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsResolucion1.master_caps);
                conn.Close();
                //this.grResolucion.Enabled = false;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void grLookEdit_Rubro_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grLookEdit_Rubro.Text))
                return;

            int IdRubro = Convert.ToInt32(grLookEdit_Rubro.EditValue);
            LoadCaps(IdRubro);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grLookEdit_Rubro.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar un Rubro!");
                grLookEdit_Rubro.Focus();
                return; 
            }
            if (string.IsNullOrEmpty(grLookEdit_Capitulo.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar un Capítulo!");
                grLookEdit_Capitulo.Focus();
                return;
            }

            if (spinEditSaldoInicial.Value <= 0)
            {
                CajaDialogo.Error("Es necesario un saldo inicial mayor a cero!");
                spinEditSaldoInicial.Focus();
                return;
            }
            if (spinEditSaldoDisponible.Value < 0)
            {
                CajaDialogo.Error("Es necesario un saldo disponible mayor o igual a cero!");
                spinEditSaldoDisponible.Focus();
                return;
            }
            if (spinEditPagos.Value < 0)
            {
                CajaDialogo.Error("Es necesario un # de pagos mayor o igual a cero!");
                spinEditPagos.Focus();
                return;
            }



            try
            {
                string queryval = "sp_get_duplicate_cap_from_resolution";


                //string sql = @"sp_set_insert_saldo_new_cap_from_rub_and_resolution";
                //DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                //conn.Open();

                //SqlCommand cmdVal = new SqlCommand(queryval, conn);
                //cmdVal.CommandType = CommandType.StoredProcedure;
                //cmdVal.Parameters.AddWithValue("@idcap", grLookEdit_Capitulo.EditValue);
                //cmdVal.Parameters.AddWithValue("@idres", IdResolucion);
                //SqlDataReader dr = cmdVal.ExecuteReader();
                //if (dr.Read())
                //{
                //    string codigo = dr.GetString(2);
                //    string descrip = dr.GetString(3);
                //    decimal inicial = dr.GetDecimal(4);
                //    decimal saldo = dr.GetDecimal(5);
                //    decimal pagos = dr.GetDecimal(6);

                //    string mesj = $"Ya se registro este Capítulo en esta resolución!  Los datos Registrados son:\nCodigo {codigo},\nCap {descrip},\nSaldo Inicial" +
                //                  $"{inicial}\nSaldo Actual {saldo}\nPagos {pagos}";
                //    CajaDialogo.Error(mesj);
                //    dr.Close();
                //    return;
                //}
                //dr.Close();


                DialogResult r = CajaDialogo.Pregunta("¿Confirma que desea agregar este capítulo y sus saldos?");
                if (r != DialogResult.Yes)
                    return;

                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                string sql = @"sp_set_update_saldos_capitulo_resolucion";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                bool Enabled = true;
                if (toggleSwitch1.IsOn)
                    Enabled = false;

                cmd.Parameters.AddWithValue("@id", IdCapRow);
                cmd.Parameters.AddWithValue("@monto_inicial", spinEditSaldoInicial.Value);
                cmd.Parameters.AddWithValue("@saldo_actual", spinEditSaldoDisponible.Value);
                cmd.Parameters.AddWithValue("@pagos", spinEditPagos.Value);
                cmd.Parameters.AddWithValue("@enable", Enabled);
                cmd.ExecuteNonQuery();
                conn.Close();
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }



        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                DialogResult r = CajaDialogo.Pregunta("Esta accion eliminara la configuracion de Saldo para este Capítulo. ¿Esta seguro(a) que desea eliminarlo?");
                if (r != DialogResult.Yes)
                {
                    toggleSwitch1.IsOn = false;
                }
            }
        }
    }
}