using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PRININ.Classes
{
    class SecOps
    {
        public DataSet ValidateUser(string user, string password)
        {
            DataSet toreturn = new DataSet();
            DBOperations dp = new DBOperations();

            toreturn = dp.PRININ_GetSelectData(@"SELECT TOP 1 [id]
                                                      ,[alias]
                                                      ,[nombre]
                                                      ,[defaultheme]
                                                  FROM [dbo].[USUARIOS_CONFIG]
                                                  where [alias] = '" + user + @"';");
            if (toreturn.Tables[0].Rows.Count > 0)
            {
                return toreturn;
            }
            else
            {
                return null;
            }

        }

    }
}
