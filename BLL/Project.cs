using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prj_PracticeMidterm.DAL;

namespace Prj_PracticeMidterm.BLL
{
    public class Project
    {
        public string ProjectCode { get; set; }
        public string ProjectTitle { get; set; }
        public DateTime DueDate { get; set; }

        public List<Project> GetProjectList()
        {
            return ProjectDb.GetAllRecords();
        }

        public List<Project> GetStudentProjects(int id)
        {
            return ProjectDb.GetStudentProjects(id);
        }


    }
}