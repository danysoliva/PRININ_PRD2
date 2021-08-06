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
    public partial class frmCAIProv : Form
    {
        public frmCAIProv()
        {
            InitializeComponent();
            LoadData();
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
            dsMante.cai_provRow row1 = dsMante.cai_prov.Newcai_provRow();
            dsMante.cai_prov.Addcai_provRow(row1);
            dsMante.AcceptChanges();

            //repositoryItemGridLookUpEdit1.View.PopulateColumns(repositoryItemGridLookUpEdit1.DataSource);
            //repositoryItemGridLookUpEdit1.View.Columns[0].Visible = false;
        }

        private void repositoryItemDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de desactivar este CAI?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridView1 = (DevExpress.XtraGrid.Views.Grid.GridView)gridControlCAI.FocusedView;
            var row = (dsMante.cai_provRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
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
            if (gridView1.DataRowCount == 0)
            {
                CajaDialogo.Pregunta("Se va guardar sin haber ingresado ningun CAI?");
                return;
            }
            if (gridProv.Text == "")
            {
                CajaDialogo.Error("Debe elegir un Proveedor");
                gridProv.Focus();
                return;
            }
            //Validar que la informacion de los CAI no esta vacia
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
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

            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                string sql = @"INSERT INTO [dbo].[CAI_Proveedores]
                               ([cod_prov]
                               ,[CAI]
                               ,[rango]
                               ,[fecha_limite]
                               ,[activo]
                               ,[fecha_creado]
                               ,[usuario])
                         VALUES
                               (@cod_prov>
                               ,@CAI, varchar(50),>
                               ,@rango, varchar(50),>
                               ,@fecha_limite, datetime,>
                               ,@activo, bit,>
                               ,@fecha_creado, datetime,>
                               ,@usuario)";
            }
        }

        private void cmdAbrirBusqueda_Click(object sender, EventArgs e)
        {
            LookProveedor();                       
        }

        private void LookProveedor()
        {
            frmBuscarProveedor frm = new frmBuscarProveedor();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodigoProveedor.Text = frm.Pro_codigo;
                txtProveedor.Text = frm.Pro_nombre;
            }
        }
    }
}
