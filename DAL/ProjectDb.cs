using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prj_PracticeMidterm.BLL;
using System.Data.SqlClient;

namespace Prj_PracticeMidterm.DAL
{
    public class ProjectDb
    {
        public static List<Project> GetAllRecords()
        {
            List<Project> listP = new List<Project>();
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Projects", conn);
                SqlDataReader reader = cmdSelectAll.ExecuteReader();
                Project proj;
                while (reader.Read())
                {
                    proj = new Project();
                    proj.DueDate = Convert.ToDateTime(reader["DueDate"]);
                    proj.ProjectCode = reader["ProjectCode"].ToString();
                    proj.ProjectTitle = reader["ProjectTitle"].ToString();
                    listP.Add(proj);
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

            return listP;
        }

        public static List<Project> GetStudentProjects(int studNum)
        {
            List<Project> listP = new List<Project>();
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdSearchById = new SqlCommand();
                cmdSearchById.Connection = conn;
                cmdSearchById.CommandText = "SELECT PA.StudentNumber, P.ProjectCode, P.ProjectTitle, P.DueDate " +
                    "                        FROM Projects P, ProjectAssignments PA" +
                    "                        WHERE PA.StudentNumber = @StudentNumber " +
                    "                        AND PA.ProjectCode = P.ProjectCode";

                cmdSearchById.Parameters.AddWithValue("@StudentNumber", studNum);
                SqlDataReader reader = cmdSearchById.ExecuteReader();// this is for search
                Project proj;
                while (reader.Read())
                {
                    proj = new Project();
                    proj.DueDate = Convert.ToDateTime(reader["DueDate"]);
                    proj.ProjectCode = reader["ProjectCode"].ToString();
                    proj.ProjectTitle = reader["ProjectTitle"].ToString();
                    listP.Add(proj);
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

            return listP;
        }






    }
}