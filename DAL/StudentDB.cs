using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prj_PracticeMidterm.BLL;
using System.Data.SqlClient;

namespace Prj_PracticeMidterm.DAL
{
    public class StudentDB
    {
        public static List<Student> GetAllRecords()
        {

            List<Student> listS = new List<Student>();
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Students", conn);
                SqlDataReader reader = cmdSelectAll.ExecuteReader();
                Student stud;
                while (reader.Read())
                {
                    stud = new Student();
                    stud.StudentNum = Convert.ToInt32(reader["StudentNumber"]);
                    stud.FirstName = reader["FirstName"].ToString();
                    stud.LastName = reader["LastName"].ToString();
                    stud.Password = reader["Password"].ToString();
                    listS.Add(stud);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listS;
        }

        public static Student SearchRecord(int studNum)
        {

            Student stud = new Student();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT * FROM Students WHERE StudentNumber = @StudentNumber";
            cmdSearchById.Parameters.AddWithValue("@StudentNumber", studNum);
            SqlDataReader reader = cmdSearchById.ExecuteReader();// this is for search
            while (reader.Read())
            {

                stud.FirstName = reader["FirstName"].ToString(); ;
                stud.LastName = reader["LastName"].ToString();
                stud.StudentNum = Convert.ToInt32(reader["StudentNumber"]);
                stud.Password = reader["Password"].ToString();
                return stud;
            }

            return null;

        }

        public static Student SearchName(int studNum)
        {
            Student stud = new Student();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT FirstName, LastName " +
                "                        FROM Students" +
                "                        WHERE StudentNumber = @StudentNumber";
            cmdSearchById.Parameters.AddWithValue("@StudentNumber", studNum);
            SqlDataReader reader = cmdSearchById.ExecuteReader();
            while (reader.Read())
            {
                stud.FirstName = reader["FirstName"].ToString();
                stud.LastName = reader["LastName"].ToString();
                return stud;
            }
            return null;
        }

        public static List<Student> GetStudentFromProject(string projCode)
        {

            List<Student> listS = new List<Student>();
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdSearchById = new SqlCommand();
                cmdSearchById.Connection = conn;
                cmdSearchById.CommandText = "SELECT PA.StudentNumber, S.FirstName, S.LastName" +
                    "                        FROM ProjectAssignments PA, Students S" +
                    "                        WHERE PA.StudentNumber = S.StudentNumber " +
                    "                        AND PA.ProjectCode = @ProjectCode";

                cmdSearchById.Parameters.AddWithValue("@ProjectCode", projCode);
                SqlDataReader reader = cmdSearchById.ExecuteReader();// this is for search
                Student stud;
                while (reader.Read())
                {
                    stud = new Student();
                    stud.FirstName = reader["FirstName"].ToString();
                    stud.LastName = reader["LastName"].ToString();
                    stud.StudentNum = Convert.ToInt32(reader["StudentNumber"]);
                    listS.Add(stud);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listS;

        }
    }
}