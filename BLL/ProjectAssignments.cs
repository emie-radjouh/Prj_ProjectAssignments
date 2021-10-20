using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prj_PracticeMidterm.DAL;

namespace Prj_PracticeMidterm.BLL
{
    public class ProjectAssignments
    {
        public int StudentNumber { get; set; }
        public string ProjectCode { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime SubmittedDate { get; set; }

        public List<ProjectAssignments> listAllProjectAssigned()
        {
            return ProjectAssignmentsDB.listAllProjectAssigned();
        }

        public void AssignedProject(ProjectAssignments projA)
        {
            ProjectAssignmentsDB.AssignProject(projA);
        }

   
    }
}