using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PRININ.Classes;

namespace PRININ
{
    public partial class Mantenimiento_Correlativo : Form
    {
        DBOperations dp;
        Monedas Coint;
        int Vmoneda;
        string codigo;
        public Mantenimiento_Correlativo()
        {
            InitializeComponent();
            Coint = new Monedas();
            if (togMoneda.IsOn)
            {
                Vmoneda = 2;//Dolar
                codigo = Coint.GenerarSiguienteCodigo(Vmoneda);
            }
            else
            {
                Vmoneda = 1;//Lempiras
                codigo = Coint.GenerarSiguienteCodigo(Vmoneda);
            }
            textSiguiente.Text = codigo;
        }

        private void butCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void togMoneda_Toggled(object sender, EventArgs e)
        {
            Coint = new Monedas();
            dp = new DBOperations();
            if (togMoneda.IsOn == true)
            {
                Vmoneda = 2;//Dolar
                codigo = Coint.GenerarSiguienteCodigo(Vmoneda);
            }
            else
            {
                Vmoneda = 1;//Lempiras
                codigo = Coint.GenerarSiguienteCodigo(Vmoneda);
            }
            textSiguiente.Text = codigo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dp = new DBOperations();
                string Query;
                string update,pref,var;
                if (textNuevo.Text != "")
                {

               
               
                    DialogResult resp = MessageBox.Show("Se va sustituir el codigo: " + textSiguiente.Text + " por el codigo: " + textNuevo.Text+" ¿Deseas continuar? .", "Informacion",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (resp == DialogResult.Yes)
                    {
                        update = textNuevo.Text;
                        pref = update.Substring(0, 3);
                        var = update.Substring(3);
                        Query = @"UPDATE dbo.[conf_tables_id]
                                SET prefijo = '" + pref +
                                    "', [siguiente] = " + var + 
                                    " WHERE id = " + Vmoneda;
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringPRININ);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(Query,cn);
                        cmd.ExecuteNonQuery();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el nuevo secuencia de codigo");

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("El dato debe tener el mismo tamaño del codigo anterior");
                MessageBox.Show(ex.Message);
            }
           
        }
    }
    }

