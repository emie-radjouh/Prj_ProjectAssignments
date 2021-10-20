using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prj_PracticeMidterm.BLL;

namespace Prj_PracticeMidterm.GUI
{
    public partial class WebFormProjectAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            List<Student> listS = aStudent.GetStudentList();
            foreach (Student s in listS)
            {
                DropDownStudent.Items.Add(s.StudentNum.ToString() + ", " + s.FirstName + ", " + s.LastName);
            }

            Project aProject = new Project();
            List<Project> listP = aProject.GetProjectList();
            foreach (Project p in listP)
            {
                DropDownProject.Items.Add(p.ProjectCode.ToString() + ", " + p.ProjectTitle);
            }
        }

        protected void DropDownStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}