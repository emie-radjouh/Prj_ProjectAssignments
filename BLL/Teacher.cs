using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prj_PracticeMidterm.DAL;

namespace Prj_PracticeMidterm.BLL
{
    public class Teacher
    {
        public int TeacherNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public Teacher SearchTeacher(int id)
        {
            return TeacherDB.SearchRecord(id);
        }

        public Teacher SearchTeacherName(int id)
        {
            return TeacherDB.SearchName(id);
        }

    }
}