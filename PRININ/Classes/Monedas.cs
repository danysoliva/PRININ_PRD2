using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PRININ.Classes;


namespace PRININ.Classes
{
    class Monedas
    {
        DBOperations dp;
        public Monedas()
        {
            
        }
        public string GenerarSiguienteCodigo(int pMoneda)
        {
            

            string cod = "";
            string val = "";
            string pref = "";
            try
            {dp = new DBOperations();
                string sql = @"SELECT prefijo, siguiente
                               FROM conf_tables_id
                               WHERE id = " + pMoneda;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pref = dr.GetString(0);
                    val = dr.GetInt32(1).ToString();
                    while (val.Length < 4)
                    {
                        val = "0" + val;
                    }
                    cod = pref + val;

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cod;
        }
        public void UpdateCam(int Pmoneda)
        {
            try
            { dp = new DBOperations();
                string qry;
                qry = @"UPDATE dbo.[conf_tables_id]
                           SET 
                              [siguiente] = siguiente + 1
                         WHERE id = "+Pmoneda;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringPRININ);
                cn.Open();
                SqlCommand cmd = new SqlCommand(qry, cn);
                cmd.ExecuteNonQuery();
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
