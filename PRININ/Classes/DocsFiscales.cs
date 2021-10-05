using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRININ.Classes
{
    public class DocsFiscales
    {
        public string Leyenda;
        public bool Recuperado;
        public int Id;
        public string CAI;
        public string RInicial;
        public string RFinal;
        public string RangoFrase;
        public const string Factura = "FA";
        public const string NotaCredito = "NC";
        public const string NotaDebito = "ND";
        public DateTime Desde;
        public DateTime Hasta;

        public enum DocType
        {
            Factura = 1,
            NotaCredito = 2,
            NotaDebito = 3
        }

        public DocsFiscales()
        {

        }

        public bool RecuperarRegistro(DocType pTipo)
        {
            string var = "";
            switch(pTipo)
            {
                case DocType.Factura:
                    var = Factura;
                    break;
                case DocType.NotaCredito:
                    var = NotaCredito;
                    break;
                case DocType.NotaDebito:
                    var = NotaDebito;
                    break;
            }

            Recuperado = false;
            try
            {
                string sql = @"SELECT [id]
	                                ,[leyenda]
                                    ,[cai]
                                    ,[fecha_emision]
                                    ,[fecha_vence]
                                    ,[num_ini]
                                    ,[num_fin]
                                    ,[estado]
                                    ,[created_date]
                                    ,[created_by]
                                    ,[created_from]
                                    ,[kind]
                                    ,[gen_corr]
                                    ,[correlative]
                                    ,[TypeDoc]
                                FROM [dbo].[z_INVREGDAT]
                                where TypeDoc = @type
                                    and estado = 'a'";
                DBOperations dp = new DBOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringPRININ);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@type", var);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Recuperado = true;
                    Id = dr.GetInt32(0);
                    CAI = dr.GetString(2);
                    Desde = dr.GetDateTime(3);
                    Hasta = dr.GetDateTime(4);
                    RInicial = dr.GetString(5);
                    RFinal = dr.GetString(6);
                    Leyenda = dr.GetString(1);
                    RangoFrase = "Número Inicial: " + RInicial + " / Final: " + RFinal;
                }
                dr.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

    }
}
