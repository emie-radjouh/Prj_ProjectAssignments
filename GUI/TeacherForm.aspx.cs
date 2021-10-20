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
    public partial class TeacherForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            Teacher aTeacher = new Teacher();
            int id = Convert.ToInt32(Session["id"]);
            aTeacher = aTeacher.SearchTeacherName(id);
            string tFirstName = aTeacher.FirstName;
            string tLastName = aTeacher.LastName;

            lblWelcome.Text = "Welcome, " + tFirstName + " " + tLastName;

            List<Student> listS = aStudent.GetStudentList();
            foreach (Student s in listS)
            {
                DropListStudents.Items.Add(s.StudentNum.ToString() + ", " + s.FirstName + ", " + s.LastName + ", " + s.StudentNum);
            }

            Project aProject = new Project();
            List<Project> listP = aProject.GetProjectList();
            foreach (Project p in listP)
            {
                DropListProjects.Items.Add(p.ProjectCode.ToString() + ", " + p.ProjectTitle);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAssign_Click(object sender, EventArgs e)
        {
            string student = DropListStudents.SelectedValue;
            String[] field = student.Split(',');
            int id = Convert.ToInt32(field[0]);

            string project = DropListProjects.SelectedValue;
            String[] field2 = project.Split(',');
            string code = field2[0];

            ProjectAssignments projA = new ProjectAssignments();
            List<ProjectAssignments> listPA = projA.listAllProjectAssigned();

            foreach(ProjectAssignments pa in listPA)
            {
                if((id == pa.StudentNumber) && (code == pa.ProjectCode))
                {
                    MessageBox.Show("This project has already been assigned to this student", "Already assigned",MessageBoxButton.OK);
                    return;
                }
                else
                {
                    projA.StudentNumber = id;
                    projA.ProjectCode = code;
                    projA.SubmittedDate = Convert.ToDateTime(calendarSubmit.SelectedDate.ToString());
                    projA.AssignedDate = Convert.ToDateTime(calendarAssigned.SelectedDate.ToString());
                    projA.AssignedProject(projA);
                    MessageBox.Show("This project has successfully been assigned to this student", "Assigned", MessageBoxButton.OK);
                }
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            Project proj = new Project();
            string student = DropListStudents.SelectedValue;
            String[] field = student.Split(',');
            int id = Convert.ToInt32(field[0]);

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

        protected void btnListStudents_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            string project = DropListProjects.SelectedValue;
            String[] field = project.Split(',');
            string projCode = field[0];

            List<Student> listS = stud.GetStudentFromProject(projCode);
            if(listS.Count != 0)
            {
                gridViewStudents.DataSource = listS;
                gridViewStudents.DataBind();
            }
            else
            {
                MessageBox.Show("This project does not belong to any students", "Empty List", MessageBoxButton.OK);
            }

        }
    }
}