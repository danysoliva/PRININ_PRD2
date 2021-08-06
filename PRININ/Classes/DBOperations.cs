using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRININ.Classes
{
    class DBOperations
    {
        #region Aquafeed Related Connection Strings

        //internal string ConnectionStringCostos = @"Server=" + Globals.CTS_ServerAddress + @";
        //                                           Database=" + Globals.CTS_ActiveDB + @";
        //                                           User Id=" + Globals.CTS_DB_User + @";
        //                                           Password=" + Globals.CTS_DB_Pass + ";";

        //internal string ConnectionStringConsola = @";Database=" + Globals.CMS_ActiveDB + @";
        //                                            User Id=" + Globals.CMS_DB_User + @";
        //                                            Password=" + Globals.CMS_DB_Pass + ";";

        //internal string ConnectionStringPelletServer = @"Server=" + Globals.CMS_ServerPellet + @";
        //                                               Database=" + Globals.CMS_ActiveDB + @";
        //                                               User Id=" + Globals.CMS_DB_User + @";
        //                                               Password=" + Globals.CMS_DB_Pass + ";";

        //internal string ConnectionStringExtruderServer = @"Server=" + Globals.CMS_ServerExtruder + @";
        //                                               Database=" + Globals.CMS_ActiveDB + @";
        //                                               User Id=" + Globals.CMS_DB_User + @";
        //                                               Password=" + Globals.CMS_DB_Pass + ";";

        //internal string ConnectionStringODOO = @"Server=" + Globals.odoo_ServerAddress + @";
        //                                         Port=5432;
        //                                         Database=" + Globals.odoo_ActiveDB + @";
        //                                         User Id=" + Globals.odoo_DB_User + @";
        //                                         Password=" + Globals.odoo_DB_Pass + @";
        //                                         CommandTimeout=20;";

        #endregion

        #region Nutreco Related Connection Strings

        internal string ConnectionStringPRININ = @"Server=" + Globals.prinin_ServerAddress + @";
                                                   Database=" + Globals.prinin_ActiveDB + @";
                                                   User Id=" + Globals.prinin_DB_User + @";
                                                   Password=" + Globals.prinin_DB_Pass + ";";

        #endregion

        #region Nutreco Related Methods

        public DataSet PRININ_GetSelectData(string FixedQuery)
        {
            DataSet data = new DataSet();

            SqlConnection Conn = new SqlConnection(ConnectionStringPRININ);
            Conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(FixedQuery, Conn);
            adapter.Fill(data);

            Conn.Close();

            return data;
        }

        public int PRININ_Exec_SP_GetID(string Procedure_Name, SqlCommand command, SqlParameter returnParameter)
        {
            Int32 ID;

            SqlConnection conn = new SqlConnection(ConnectionStringPRININ);

            if (command.CommandType == CommandType.StoredProcedure)
            {
                command.Connection = conn;
                command.CommandText = Procedure_Name;
                conn.Open();
                command.ExecuteNonQuery();

                ID = Convert.ToInt32(returnParameter.Value);

                conn.Close();
            }
            else
            {
                ID = -1;
            }

            return ID;
        }

        public void PRININ_Exec_SP(string Procedure_Name, SqlCommand command)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionStringPRININ);

                if (command.CommandType == CommandType.StoredProcedure)
                {
                    command.Connection = conn;
                    command.CommandText = Procedure_Name;
                    conn.Open();
                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public DataTable PRININ_Exec_SP_Get_Data(string Procedure_Name, SqlCommand command)
        {
            DataTable data = new DataTable();

            SqlConnection conn = new SqlConnection(ConnectionStringPRININ);

            command.CommandText = Procedure_Name;
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            conn.Open();

            data.Load(command.ExecuteReader());

            conn.Close();

            return data;
        }

        public int PRININ_InsertAndReturnID(string Command)
        {
            Int32 InsertedID;
            SqlConnection conn = new SqlConnection(ConnectionStringPRININ);
            conn.Open();

            SqlCommand cmd = new SqlCommand(Command, conn);

            InsertedID = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return InsertedID;
        }

        public DateTime Now()
        {
            DateTime valor;
            SqlConnection conn = new SqlConnection(ConnectionStringPRININ);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select getdate()", conn);

            valor = Convert.ToDateTime(cmd.ExecuteScalar());

            conn.Close();

            return valor;
        }
        public void PRININ_DoSmallDBOperation(string Command)
        {
            SqlConnection conn = new SqlConnection(ConnectionStringPRININ);
            conn.Open();

            SqlCommand cmd = new SqlCommand(Command, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        #endregion

    }
}
