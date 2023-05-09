using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRININ.Classes
{
    public class FacturaH
    {
        public int Id;
        public string invoice_number;
        public DateTime due_date;
        public DateTime invoice_date;
        public int local_tax_id;
        public string customer_code;
        public string customer_long_name;
        public string customer_rtn;
        public string aditional_line1;
        public string aditional_line2;
        public string aditional_line3;
        public string aditional_line4;
        public string aditional_line5;
        public string aditional_line6;
        public string RegistroExoneradoC;
        public string ID_SAG;
        public string OC_Exenta;

        public string created_by;
        public DateTime created_date;
        public string created_from;
        public string cust_po_number;
        public int id_credit_term;
        public string Credit_term_description;
        public string shipping_addess;
        public string shipping_country;
        public string record_ex;
        public int credit_days;
        public string id_currency;
        public string CurrencyDescripcion;
        public bool canceled;
        public string invoice_number_fiscal;
        public decimal TasaCambio;
        public decimal TotalFacturaUSD;
        public decimal SubTotal;
        public decimal TotalDiscount;
        public decimal TotalISV;
        public string PaisNombre;
        public bool Recuperado;

        public string CodeWindow { get { return "WD0001"; } }

        public FacturaH()
        {

        }

        public bool RecuperarRegistro(int pId)
        {
            try
            {
                string sql = @"sp_get_facturas_united_header";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                //string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                string ConnectionString = dp.ConnectionStringPRININ;
                SqlConnection conn = new SqlConnection(ConnectionString);

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = pId;
                    invoice_number = dr.GetString(0);
                    due_date = dr.GetDateTime(1);
                    invoice_date = dr.GetDateTime(2);
                    if (!dr.IsDBNull(dr.GetOrdinal("local_tax_id")))
                        local_tax_id = dr.GetInt32(3);

                    customer_code = dr.GetString(4);
                    customer_long_name = dr.GetString(5);

                    customer_rtn = dr.GetString(6);
                    if (!dr.IsDBNull(dr.GetOrdinal("aditional_line1")))
                        aditional_line1 = dr.GetString(7);
                    if (!dr.IsDBNull(dr.GetOrdinal("aditional_line2")))
                        aditional_line2 = dr.GetString(8);
                    if (!dr.IsDBNull(dr.GetOrdinal("aditional_line3")))
                        aditional_line3 = dr.GetString(9);
                    if (!dr.IsDBNull(dr.GetOrdinal("aditional_line4")))
                        aditional_line4 = dr.GetString(10);
                    if (!dr.IsDBNull(dr.GetOrdinal("aditional_line5")))
                        aditional_line5 = dr.GetString(11);
                    if (!dr.IsDBNull(dr.GetOrdinal("aditional_line6")))
                        aditional_line6 = dr.GetString(12);

                    created_by = dr.GetString(13);

                    created_date = dr.GetDateTime(14);
                    //
                    if (!dr.IsDBNull(dr.GetOrdinal("created_from")))
                        created_from = dr.GetString(15);

                    if (!dr.IsDBNull(dr.GetOrdinal("cust_po_number")))
                        cust_po_number = dr.GetString(16);

                    id_credit_term = dr.GetInt32(17);

                    shipping_addess = dr.GetString(18);

                    shipping_country = dr.GetString(19);

                    record_ex = dr.GetString(20);

                    credit_days = dr.GetInt32(21);
                    canceled = dr.GetBoolean(22);

                    id_currency = dr.GetString(23);
                    //
                    if (!dr.IsDBNull(dr.GetOrdinal("invoice_number_fiscal")))
                        invoice_number_fiscal = dr.GetString(24);



                    Credit_term_description = dr.GetString(25);
                    CurrencyDescripcion = dr.GetString(26);
                    
                    PaisNombre = dr.GetString(27);
                    if (!dr.IsDBNull(dr.GetOrdinal("exchange_rate")))
                        TasaCambio = dr.GetDecimal(28);
                    else
                        TasaCambio = 1;

                    if (!dr.IsDBNull(dr.GetOrdinal("total_fact_usd")))
                        TotalFacturaUSD = dr.GetDecimal(29);
                    else
                        TotalFacturaUSD = 1;

                    if (!dr.IsDBNull(dr.GetOrdinal("reg_exo")))
                        RegistroExoneradoC = dr.GetString(30);

                    if (!dr.IsDBNull(dr.GetOrdinal("oc_exenta")))
                        OC_Exenta = dr.GetString(31);

                    if (!dr.IsDBNull(dr.GetOrdinal("reg_sag")))
                        ID_SAG = dr.GetString(32);

                    if (!dr.IsDBNull(dr.GetOrdinal("sub")))
                        SubTotal = dr.GetDecimal(33);
                    if (!dr.IsDBNull(dr.GetOrdinal("discount")))
                        TotalDiscount = dr.GetDecimal(34);
                    if (!dr.IsDBNull(dr.GetOrdinal("isv")))
                        TotalISV = dr.GetDecimal(35);


                    Recuperado = true;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool RecuperarRegistroForM3_Invoice(int pId)
        {
            try
            {
                string sql = @"[sp_get_factura_from_M3_by_id]";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = pId;
                    invoice_number = dr.GetString(0);
                    //due_date = dr.GetDateTime(1);
                    invoice_date = dr.GetDateTime(1);
                    if (!dr.IsDBNull(dr.GetOrdinal("customer_code")))
                        customer_code = dr.GetString(2);

                    customer_long_name = dr.GetString(3);
                    customer_rtn = dr.GetString(4);
                    if (!dr.IsDBNull(dr.GetOrdinal("numero_factura_hn")))
                        invoice_number_fiscal = dr.GetString(5);

                    //if (!dr.IsDBNull(dr.GetOrdinal("aditional_line1")))
                    //    aditional_line1 = dr.GetString(7);
                    //if (!dr.IsDBNull(dr.GetOrdinal("aditional_line2")))
                    //    aditional_line2 = dr.GetString(8);
                    //if (!dr.IsDBNull(dr.GetOrdinal("aditional_line3")))
                    //    aditional_line3 = dr.GetString(9);
                    //if (!dr.IsDBNull(dr.GetOrdinal("aditional_line4")))
                    //    aditional_line4 = dr.GetString(10);
                    //if (!dr.IsDBNull(dr.GetOrdinal("aditional_line5")))
                    //    aditional_line5 = dr.GetString(11);
                    //if (!dr.IsDBNull(dr.GetOrdinal("aditional_line6")))
                    //    aditional_line6 = dr.GetString(12);

                    //created_by = dr.GetString(13);

                    //created_date = dr.GetDateTime(14);
                    //
                    //if (!dr.IsDBNull(dr.GetOrdinal("created_from")))
                    //    created_from = dr.GetString(15);

                    //cust_po_number = dr.GetString(16);

                    //id_credit_term = dr.GetInt32(17);

                    //shipping_addess = dr.GetString(18);

                    //shipping_country = dr.GetString(19);

                    //record_ex = dr.GetString(20);

                    //credit_days = dr.GetInt32(21);
                    //canceled = dr.GetBoolean(22);

                    //id_currency = dr.GetString(23);
                    ////
                    



                    //Credit_term_description = dr.GetString(25);
                    //CurrencyDescripcion = dr.GetString(26);

                    //PaisNombre = dr.GetString(27);
                    //if (!dr.IsDBNull(dr.GetOrdinal("exchange_rate")))
                    //    TasaCambio = dr.GetDecimal(28);
                    //else
                    //    TasaCambio = 1;

                    //if (!dr.IsDBNull(dr.GetOrdinal("total_fact_usd")))
                    //    TotalFacturaUSD = dr.GetDecimal(29);
                    //else
                    //    TotalFacturaUSD = 1;

                    //if (!dr.IsDBNull(dr.GetOrdinal("reg_exo")))
                    //    RegistroExoneradoC = dr.GetString(30);

                    //if (!dr.IsDBNull(dr.GetOrdinal("oc_exenta")))
                    //    OC_Exenta = dr.GetString(31);

                    //if (!dr.IsDBNull(dr.GetOrdinal("reg_sag")))
                    //    ID_SAG = dr.GetString(32);

                    //if (!dr.IsDBNull(dr.GetOrdinal("sub")))
                    //    SubTotal = dr.GetDecimal(33);
                    //if (!dr.IsDBNull(dr.GetOrdinal("discount")))
                    //    TotalDiscount = dr.GetDecimal(34);
                    //if (!dr.IsDBNull(dr.GetOrdinal("isv")))
                    //    TotalISV = dr.GetDecimal(35);


                    Recuperado = true;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool UpdateRegistro(int pId)
        {
            bool val = false;
            try
            {
                string sql = @"[sp_set_update_aditionals_data_invoiceh_v2]";
                DBOperations dp = new DBOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                string ConnectionString = dp.Get_Prinin_db_window_assigned(this.CodeWindow);
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idf", pId);
                if(local_tax_id ==0)
                    cmd.Parameters.AddWithValue("@local_tax_id", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@local_tax_id", local_tax_id);

                cmd.Parameters.AddWithValue("@aditional_line1", aditional_line1);
                cmd.Parameters.AddWithValue("@aditional_line2", aditional_line2);
                cmd.Parameters.AddWithValue("@aditional_line3", aditional_line3);
                cmd.Parameters.AddWithValue("@aditional_line4", aditional_line4);
                cmd.Parameters.AddWithValue("@aditional_line5", aditional_line5);
                cmd.Parameters.AddWithValue("@aditional_line6", aditional_line6);
                cmd.Parameters.AddWithValue("@reg", RegistroExoneradoC);
                cmd.Parameters.AddWithValue("@oc", OC_Exenta);
                cmd.Parameters.AddWithValue("@sag", ID_SAG);
                cmd.Parameters.AddWithValue("@invoice_number_fiscal", invoice_number_fiscal);
                cmd.Parameters.AddWithValue("@exchange_rate", TasaCambio);
                cmd.Parameters.AddWithValue("@purchase_order", cust_po_number);
                cmd.ExecuteNonQuery();
                val = true;
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }










    }
}
