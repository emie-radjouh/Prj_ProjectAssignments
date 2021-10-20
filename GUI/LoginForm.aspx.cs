using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prj_PracticeMidterm.BLL;
using Prj_PracticeMidterm.Validation;
using System.Windows;




namespace Prj_PracticeMidterm.GUI
{
    public partial class LoginForm : System.Web.UI.Page
    {
        bool loginAccess;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {

        }
        protected void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text.Trim());
            string password = txtPassword.Text.Trim();

            if(!ValidationNameID.IsValidId(id.ToString()))
            {
                MessageBox.Show("Id must only be integers", "Invalid ID",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                txtID.Text = "";
                txtID.Focus();
                return;
            }
            else
            {

                if (rbStudent.Checked == true)
                {
                    Student aStudent = new Student();
                    aStudent = aStudent.SearchStudent(id);

                    if (aStudent != null)
                    {
                        if (aStudent.StudentNum == id && aStudent.Password == password)
                        {
                            loginAccess = true;
                            MessageBox.Show("Login is successful!", "Successful", MessageBoxButton.OK);
                           
                        }
                        else
                        {
                            loginAccess = false;
                            MessageBox.Show("Password is incorrect! Please try again", "Incorrect", MessageBoxButton.OK);
                            txtID.Text = "";
                            txtPassword.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID is incorrect! Please try again", "Incorrect", MessageBoxButton.OK);
                        txtID.Text = "";
                        txtPassword.Text = "";
                        loginAccess = false;

                    }

                }
                else if (rbTeacher.Checked == true)
                {
                    Teacher aTeacher = new Teacher();
                    aTeacher = aTeacher.SearchTeacher(id);

                    if (aTeacher != null)
                    {
                        if (aTeacher.TeacherNum == id && aTeacher.Password == password)
                        {
                            loginAccess = true;
                            MessageBox.Show("Login is successful!", "Successful", MessageBoxButton.OK);
                        }
                        else
                        {
                            loginAccess = false;
                            MessageBox.Show("Teacher ID or Password is incorrect! Please try again", "Incorrect", MessageBoxButton.OK);
                            txtID.Text = "";
                            txtPassword.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID  is incorrect! Please try again", "Incorrect", MessageBoxButton.OK); 
                        txtID.Text = "";
                        txtPassword.Text = "";
                        loginAccess = false;
                    }

                }
            }

            if(loginAccess == true)
            {
                if (rbStudent.Checked)
                {
                    Session["id"] = Convert.ToInt32(txtID.Text.Trim());
                    Response.Redirect("StudentForm.aspx");
                    txtID.Text = "";
                    txtPassword.Text = "";
                }
                else if (rbTeacher.Checked)
                {
                    Session["id"] = Convert.ToInt32(txtID.Text.Trim());
                    Response.Redirect("TeacherForm.aspx");
                    txtID.Text = "";
                    txtPassword.Text = "";
                }

            }
        }

    }
}