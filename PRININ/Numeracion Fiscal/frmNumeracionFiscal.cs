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
using static PRININ.Numeracion_Fiscal.frmNumeracionFiscalCRUD;

namespace PRININ.Numeracion_Fiscal
{
    public partial class frmNumeracionFiscal : DevExpress.XtraEditors.XtraForm
    {
        Users usuarioLogueado = new Users();
        public frmNumeracionFiscal(Users pUser)
        {
            InitializeComponent();
            usuarioLogueado = pUser;

            cargarDatos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNumeracionFiscalCRUD frm = new frmNumeracionFiscalCRUD(usuarioLogueado,Convert.ToInt32( TipoTransaccion.agregar));

            if (frm.ShowDialog()== DialogResult.OK)
            {

            }
        }

        private void cargarDatos()
        {
            DBOperations dp = new DBOperations();

            try
            {
                using (SqlConnection cnx= new SqlConnection(dp.ConnectionStringPRININ))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_numeracion_fiscal", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dsNumeracionFiscal.Numeracion_Fiscal.Clear();
                    da.Fill(dsNumeracionFiscal.Numeracion_Fiscal);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsNumeracionFiscal.Numeracion_FiscalRow)gvNumeracionFiscal.GetFocusedDataRow();

            if (row!=null)
            {
                NumeracionFiscal numeracionFiscal = new NumeracionFiscal();

                numeracionFiscal.ID = row.id;
                numeracionFiscal.CAI = row.cai;
                numeracionFiscal.FechaEmision = row.fecha_emision;
                numeracionFiscal.FechaVence = row.fecha_vence;
                numeracionFiscal.NumIni = row.num_ini;
                numeracionFiscal.NumFin = row.num_fin;
                numeracionFiscal.Estado = row.estado;
                numeracionFiscal.CreatedBy = row.created_by;
                numeracionFiscal.CreatedDate = row.created_date;
                numeracionFiscal.GenCorr = row.gen_corr;
                numeracionFiscal.Correlative = row.correlative;
                numeracionFiscal.Leyenda = row.leyenda;
                numeracionFiscal.TypeDoc = row.TypeDoc;

                frmNumeracionFiscalCRUD frm = new frmNumeracionFiscalCRUD(usuarioLogueado, Convert.ToInt32(TipoTransaccion.editar), numeracionFiscal); ;

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    cargarDatos();
                }
            }
        }
    }
}