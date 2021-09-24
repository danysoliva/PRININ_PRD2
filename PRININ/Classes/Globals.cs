using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRININ.Classes
{
    class Globals
    {

        #region Credenciales Producción

            #region Aquafeed

        //WINCC
        public static string CMS_ServerPellet = "10.50.11.24";
        public static string CMS_ServerExtruder = "10.50.11.23";

        public static string CMS_DB_User = "bkadmin";
        public static string CMS_DB_Pass = "AquaF33dHN2014";
        public static string CMS_ActiveDB = "process_data";

        //ACS (Costos)
        public static string CTS_ServerAddress = "AQFSVR003";
        public static string CTS_ServerName = "Servidor Productivo";
        public static string CTS_ActiveDB = "ACS";

        public static string CTS_DB_User = "sa";
        public static string CTS_DB_Pass = "AquaF33dHN2014";

        //ODOO
        public static string odoo_ServerAddress = "AQFSVR003";
        public static string odoo_ServerName = "Servidor Productivo";
        public static string odoo_ActiveDB = "aquafeed";

        public static string odoo_DB_User = "aquafeed";
        public static string odoo_DB_Pass = "Aqua3820";

        #endregion

        #region Nutreco

        //PRININ
        public static string prinin_ServerAddress = "10.50.10.19";
        public static string prinin_ServerName = "10.50.10.19";
        public static string prinin_ActiveDB = "PRININ";
        public static string prinin_DB_User = "sa";
        public static string prinin_DB_Pass = "Pr0mix2017";

        //public static string prinin_ServerAddress = $"AQFSVR007\\AQFSVR007";
        //public static string prinin_ServerName = $"AQFSVR007";
        //public static string prinin_ActiveDB = "PRININ_DEV";


        //public static string prinin_ServerAddress = $"EUCEDA\\SQLEXPRESS";
        //public static string prinin_ServerName = $"EUCEDA";
        //public static string prinin_ActiveDB = "PRININ_DEV";

        //public static string prinin_DB_User = "sa";
        //public static string prinin_DB_Pass = "AquaF33dHN2014";


        #endregion


        #endregion

        #region Credenciales Desarrollo

        #region Aquafeed

        ////WINCC
        //public static string CMS_ServerPellet = "10.50.11.50";
        //public static string CMS_ServerExtruder = "10.50.11.50";

        //public static string CMS_DB_User = "sa";
        //public static string CMS_DB_Pass = "AquaFeed2016";
        //public static string CMS_ActiveDB = "process_data";

        ////ACS (Costos)
        //public static string CTS_ServerAddress = "10.50.11.50";
        //public static string CTS_ServerName = "Servidor de Desarrollo";
        //public static string CTS_ActiveDB = "ACS";

        //public static string CTS_DB_User = "sa";
        //public static string CTS_DB_Pass = "AquaFeed2016";

        ////ODOO
        ////public static string odoo_ServerAddress = "10.50.11.50";  PC Octavio
        ////public static string odoo_ServerAddress = "odoo-pruebas-pc"; 
        //public static string odoo_ServerAddress = "10.50.11.118";   //.118
        //public static string odoo_ServerName = "Servidor de Desarrollo";
        //public static string odoo_ActiveDB = "pruebas";

        //public static string odoo_DB_User = "aquafeed"; //"aquafeed";
        //public static string odoo_DB_Pass = "Aqua3820";

        #endregion

        #region Nutreco

        //PRININ
        //public static string prinin_ServerAddress = "9DR5P32";
        //public static string prinin_ServerName = "Development Server";
        //public static string prinin_ActiveDB = "PRININ";

        //public static string prinin_DB_User = "sa";
        //public static string prinin_DB_Pass = "Promix1620";

        #endregion

        #endregion

    }
}
