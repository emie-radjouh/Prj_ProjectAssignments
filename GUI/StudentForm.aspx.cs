using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prj_PracticeMidterm.BLL;
using System.Windows;

namespace Prj_PracticeMidterm.GUI
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Student stud = new Student();
            Project proj = new Project();
            int id = Convert.ToInt32(Session["id"]);
            stud = stud.SearchStudName(id);
            string firstName = stud.FirstName;
            string lastName = stud.LastName;

            lblWelcome.Text = "Welcome, " + firstName + " " + lastName;
          
            List<Project> listP = proj.GetStudentProjects(id);
            if (listP.Count != 0)
            {
                gridViewProjects.DataSource = listP;
                gridViewProjects.DataBind();
            }
            else
            {
                MessageBox.Show("This student does not have any projects", "Empty List", MessageBoxButton.OK);

            }


        }

        protected void gridViewProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}