using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRININ.Classes
{
    public class Nota
    {
        public bool Recuperado;
        public int Id;
        public int TipoNota;
        public int TipoNotaCredito;//1 Articulos
                                   //2 Concepto

        public int SourceId;

        public Nota()
        {

        }
        public string CodeWindow { get { return "WD0002"; } }

        public int NotaSource(int pId)
        {
            //
            try
            {
                string sql = @"SELECT coalesce([source_id],0)
                                FROM [dbo].[NOTAS]
                                where id =" + pId;
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idnote", pId);
                SourceId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return SourceId;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return 0;
        }
        public bool IsNotaArticulos(int pId)
        {
            //
            try
            {
                string sql = @"sp_get_tipo_nota_generada";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idnote", pId);
                
                Recuperado = Convert.ToBoolean(cmd.ExecuteScalar());
                TipoNota = 1;
                Id = pId;
                if (Recuperado) 
                    TipoNotaCredito = 1;
                else
                    TipoNotaCredito = 2;
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
    }
}
