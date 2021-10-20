using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prj_PracticeMidterm.DAL;

namespace Prj_PracticeMidterm.BLL
{
    public class Student
    {
        public int StudentNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public List<Student> GetStudentList()
        {
            return StudentDB.GetAllRecords();
        }

        public Student SearchStudent(int id)
        {
            return StudentDB.SearchRecord(id);
        }

        public Student SearchStudName(int id)
        {
            return StudentDB.SearchName(id);
        }

        public List<Student> GetStudentFromProject(string projCode)
        {
            return StudentDB.GetStudentFromProject(projCode);
        }
    }
}