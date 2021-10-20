using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prj_PracticeMidterm.BLL;
using System.Data.SqlClient;

namespace Prj_PracticeMidterm.DAL
{
    public class TeacherDB
    {
        public static Teacher SearchRecord(int teachNum)
        {
            Teacher teach = new Teacher();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT * FROM Teachers WHERE TeacherNumber = @TeacherNumber";
            cmdSearchById.Parameters.AddWithValue("@TeacherNumber", teachNum);
            SqlDataReader reader = cmdSearchById.ExecuteReader();// this is for search
            while (reader.Read())
            {

                teach.FirstName = reader["FirstName"].ToString(); 
                teach.LastName = reader["LastName"].ToString();
                teach.TeacherNum = Convert.ToInt32(reader["TeacherNumber"]);
                teach.Password = reader["Password"].ToString();
                return teach;
            }
            

            return null;

        }

        public static Teacher SearchName(int teachNum)
        {
            Teacher teach = new Teacher();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT FirstName, LastName " +
                "                        FROM Teachers" +
                "                        WHERE TeacherNumber = @TeacherNumber";
            cmdSearchById.Parameters.AddWithValue("@TeacherNumber", teachNum);
            SqlDataReader reader = cmdSearchById.ExecuteReader();
            while (reader.Read())
            {
                teach.FirstName = reader["FirstName"].ToString();
                teach.LastName = reader["LastName"].ToString();
                return teach;
            }
            return null;
        }




    }
}