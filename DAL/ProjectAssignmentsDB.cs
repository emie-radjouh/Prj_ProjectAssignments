using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prj_PracticeMidterm.BLL;
using System.Data.SqlClient;

namespace Prj_PracticeMidterm.DAL
{
    public class ProjectAssignmentsDB
    {

        public static List<ProjectAssignments> listAllProjectAssigned()
        {


            List<ProjectAssignments> projAssignedList = new List<ProjectAssignments>();
            SqlConnection con = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("SELECT * FROM ProjectAssignments", con);
                SqlDataReader sqlreadRecord = cmdListRecord.ExecuteReader();

                ProjectAssignments projAssigned;

               while(sqlreadRecord.Read())
                {
                    projAssigned = new ProjectAssignments();

                    projAssigned.StudentNumber = Convert.ToInt32(sqlreadRecord["StudentNumber"]);
                    projAssigned.ProjectCode = sqlreadRecord["ProjectCode"].ToString();
                    projAssigned.AssignedDate = Convert.ToDateTime(sqlreadRecord["AssignedDate"]);
                    projAssigned.SubmittedDate = Convert.ToDateTime(sqlreadRecord["SubmittedDate"]);

                    projAssignedList.Add(projAssigned);
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

            return projAssignedList;

        }

        public static void AssignProject(ProjectAssignments proAs)
        {
            SqlConnection cnnDB = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();

            try
            {
                cmdInsert.CommandText = "INSERT INTO ProjectAssignments(StudentNumber,ProjectCode,AssignedDate,SubmittedDate) " +
                                            "VALUES(@StudentNumber,@ProjectCode,@AssignedDate,@SubmittedDate)";

                //cmdInsert.Parameters.AddWithValue("@StudentNumber", studNum);
                //cmdInsert.Parameters.AddWithValue("@StudentNumber", studNum);
                cmdInsert.Parameters.AddWithValue("@StudentNumber", proAs.StudentNumber);
                cmdInsert.Parameters.AddWithValue("@ProjectCode", proAs.ProjectCode);
                cmdInsert.Parameters.AddWithValue("@AssignedDate", proAs.AssignedDate);
                cmdInsert.Parameters.AddWithValue("@SubmittedDate", proAs.SubmittedDate);

                cmdInsert.Connection = cnnDB;
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                cnnDB.Close();
                cnnDB.Dispose();
            }

        }

    }
}