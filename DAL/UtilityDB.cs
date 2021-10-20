using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient; //required for ADO.Net object Model
using System.Configuration; //required for ConfigurationManager

namespace Prj_PracticeMidterm.DAL
{
    public class UtilityDB
    {

        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectEmpDB"].ConnectionString;
            conn.Open();
            return conn;

        }
    }
}