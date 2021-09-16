using PRININ.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRININ
{
    public partial class frmNotasDyC : Form
    {
       
        

        Int32 recordID;
        string ND_NC = "";
                      
       
        public frmNotasDyC(string nc_nd)
        {
            InitializeComponent();
            ND_NC = nc_nd;
            loadclientes();

            dtFechaC.Format = DateTimePickerFormat.Custom;
            dtFechaC.CustomFormat = "dd/MM/yyyy";

        }


        private void loadclientes()
        {
            //try
            //{
            //    string sql = @"SELECT [OKCONO]     
            //                          ,[OKCUNO] as Codigo
            //                          ,[OKALCU] as ClienteAbreviado 
            //                          ,[OKCUNM] as Cliente
            //                          ,[OKVRNO] as RTN	
 
            //                      FROM [PRININ].[dbo].[OCUSMA]
            //                      order by 4 asc";
            //    DBOperations dp = new DBOperations();
            //    SqlConnection Conn = new SqlConnection(dp.ConnectionStringPRININ);
            //    Conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, Conn);
                
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    adat.Fill(dsNotas.clientes);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(string.Format("Error al cargar los datos de los clientes ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void loadcai()
        {
            //try
            //{
            //    string sql = @"SELECT [id]
            //                                                                    ,[cai]
            //                                                                    ,[fecha_emision] 
            //                                                                    ,[fecha_vence] 
            //                                                                    ,[kind]
            //                                                                FROM [PRININ].[dbo].[z_INVREGDAT]
            //                                                                WHERE [estado] = 'a' and [kind]= '"+ ND_NC +"'";
            //    DBOperations dp = new DBOperations();
            //    SqlConnection Conn = new SqlConnection(dp.ConnectionStringPRININ);
            //    Conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, Conn);
            //    dsNotas.cai.Clear();
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    adat.Fill(dsNotas.cai);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(string.Format("Error al cargar datos del C.A.I ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
               
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void cmbTripoDoc_EditValueChanged_1(object sender, EventArgs e)
        //{
        //    if (cmbTripoDoc.SelectedIndex == 0) ND_NC = "ND";
        //    else if (cmbTripoDoc.SelectedIndex == 1) ND_NC = "NC";
        //    else ND_NC = "";

        //    loadcai();
        //}

        private void frmNotasDyC_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(gridCliente.Text) || gridCliente.Text == "[Vacío]")
                {
                    MessageBox.Show(string.Format("Debe seleccion un cliente "), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridCliente.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtDocumento.Text) || txtDocumento.Text == "[Vacío]")
                {
                    MessageBox.Show(string.Format("Debe agregar el numero de documento"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDocumento.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtMonto.Text) || txtMonto.Text == "[Vacío]")
                {
                    MessageBox.Show(string.Format("Debe agragar un Monto"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Focus();
                    return;
                }
                //if (string.IsNullOrEmpty(cmbTripoDoc.Text) || cmbTripoDoc.Text == "[Vacío]")
                //{
                //    MessageBox.Show(string.Format("Debe elegir el tipo de nota"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    cmbTripoDoc.Focus();
                ////    return;
                //}
                if (string.IsNullOrEmpty(txtDescripcion.Text) || txtDescripcion.Text == "[Vacío]")
                {
                    MessageBox.Show(string.Format("Debe elegir el tipo de nota"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcion.Focus();
                    return;
                }
                if (true)
                {
                    string sql = @"";
                    DBOperations dp = new DBOperations();
                    SqlConnection Conn = new SqlConnection(dp.ConnectionStringPRININ);
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, Conn);
                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al imprimir ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
