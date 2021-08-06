using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PRININ.Classes;
using System.Windows.Forms;
using PRININ;


namespace PRININ.Classes
{
    public class Users
    {
        DBOperations dp = new DBOperations();
        public SqlConnection conn;

        int id_usuario;
        string alias;
        public string nombre;
        public string Pass;

        public bool habilitado;

        public string apellido;
        bool super_user;
        public string UserDb;
        public string PassDb;
        public string theme;

        public Users()
        {
            dp = new DBOperations();
            ssd = false;
        }

        private bool ssd;

        public bool SuperUserDo
        {
            get { return ssd; }
            set { ssd = value; }
        }

        public int UserId
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //public string Pass
        //{
        //    get { return pass; }
        //    set { pass = value; }
        //}

        public string Apellido { get => apellido; set => apellido = value; }

        public bool IsSuperUser(int pUserId)
        {
            bool is_super_user = false;
            try
            {
                string sql = @"SELECT [super_user] FROM [dbo].[USUARIOS_CONFIG] where id =" + pUserId;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                is_super_user = Convert.ToBoolean(cmd.ExecuteScalar());
                conn.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show("¡No se pudo consultar si el nivel del usuario es Super User!\n" + ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return is_super_user;
        }

        public bool GuardarNuevoUsuario()
        {
            string sql = @"INSERT INTO [dbo].[USUARIOS_CONFIG]
                                           ([alias]
                                           ,[password]
                                           ,[habilitado]
                                           ,[nombre]
                                           ,[apellido]
                                           ,[super_user])
                                     VALUES
                                           (@alias,
                                           @password,
                                           @habilitado,
                                           @nombre,
                                           @apellido,
                                           @super_user)";
            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("alias", SqlDbType.VarChar).Value = this.alias;
                cmd.Parameters.Add("password", SqlDbType.VarChar).Value = EncrypPassword(this.Pass);
                cmd.Parameters.Add("habilitado", SqlDbType.Bit).Value = this.habilitado;
                cmd.Parameters.Add("nombre", SqlDbType.VarChar).Value = this.nombre;
                cmd.Parameters.Add("apellido", SqlDbType.VarChar).Value = this.Apellido;
                cmd.Parameters.Add("super_user", SqlDbType.Bit).Value = this.super_user;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        public bool ModificarUsuario()
        {
            try
            {
                string sql = @"UPDATE [dbo].[USUARIOS_CONFIG]
                                   SET [alias] = @alias
                                      ,[password] = @password
                                      ,[habilitado] = @habilitado
                                      ,[nombre] = @nombre
                                      ,[apellido] = @apellido
                                      ,[super_user] = @super_user

                                 WHERE id = @id";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id_usuario;
                cmd.Parameters.Add("alias", SqlDbType.VarChar).Value = alias;
                string a = EncrypPassword(this.Pass);
                cmd.Parameters.Add("password", SqlDbType.VarChar).Value = a;
                cmd.Parameters.Add("habilitado", SqlDbType.Bit).Value = habilitado;
                cmd.Parameters.Add("nombre", SqlDbType.VarChar).Value = nombre;
                cmd.Parameters.Add("apellido", SqlDbType.VarChar).Value = Apellido;
                cmd.Parameters.Add("super_user", SqlDbType.Bit).Value = SuperUserDo;
                cmd.ExecuteScalar();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        public string EncrypPassword(string pass)
        {
            try
            {
                byte[] enbyte = GetBytes(pass);
                string cadena_base64 = Convert.ToBase64String(enbyte);
                return cadena_base64;
            }
            catch (Exception)
            {
                return " ";
            }
        }

        public string DecryptPassword(string pass)
        {
            try
            {
                byte[] b = Convert.FromBase64String(pass);
                string cadena = GetString(b);
                return cadena;
            }
            catch
            {
                return " ";
            }
        }

        private static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        public bool RecuperarRegistros(string pAlias)
        {
            bool x = false;
            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                string sql = @"SELECT [id]
                                      ,[alias]
                                      ,[nombre]
                                      ,[super_user]
                                      ,[password]
                                      ,[habilitado]
                                  FROM [dbo].[USUARIOS_CONFIG]
                                   where [alias] = '" + pAlias + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    UserId = dr.GetInt32(0);
                    Alias = dr.GetString(1);
                    Nombre = dr.GetString(2);
                    SuperUserDo = dr.GetBoolean(3);
                    Pass = dr.GetString(4);
                    habilitado = dr.GetBoolean(5);
                }
                x = true;
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                x = false;
                CajaDialogo.Error(ex.Message);

            }
            return x;
        }

        public bool RecuperarRegistrosGestion(string pAlias)
        {

            bool Recuperar = false;
            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                string sql = @"SELECT  [id]
                                      ,[alias]
                                      ,[password]
                                      ,[habilitado]
                                      ,[nombre]
                                      ,[apellido]
                                      ,[super_user]
                                  FROM [dbo].[USUARIOS_CONFIG]
                                   where [alias] = '" + pAlias + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    UserId = dr.GetInt32(0);
                    Alias = dr.GetString(1);
                    Pass = dr.GetString(2);
                    habilitado = dr.GetBoolean(3);
                    Nombre = dr.GetString(4);
                    Apellido = dr.GetString(5);
                    SuperUserDo = dr.GetBoolean(6);
                }
                Recuperar = true;
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Recuperar = false;
                CajaDialogo.Error(ex.Message);

            }
            return Recuperar;

        }

        internal bool ValidarNivelPermisos(int pIdVentana)
        {
            bool r = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                string sql = @"select count(*)
	                                FROM [USUARIOS_VENT_CONF] vv
                                    where vv.id_venta = " + pIdVentana.ToString() +
                                    "and vv.id_usuario = " + id_usuario.ToString();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int v = Convert.ToInt32(cmd.ExecuteScalar());
                if (v > 0)
                {
                    r = true;
                }

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }
    }
}
