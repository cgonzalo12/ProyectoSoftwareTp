using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tasks
    {
        public Guid TaskID { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public Guid ProjectID { get; set; }
        public int AssignetTo { get; set; }
        public int Status { get; set; }
        public Users User { get; set; }
        public Proyects Proyect {  get; set; }
        public TaskStatus TaskStatus { get; set; }

        public Tasks()
        {
        }
        public Tasks(Guid taskID, string name, DateTime dueDate, Guid projectID, int assignetTo, int status, Users user, Proyects proyect, TaskStatus taskStatus)
        {
            TaskID = taskID;
            Name = name;
            DueDate = dueDate;
            ProjectID = projectID;
            AssignetTo = assignetTo;
            Status = status;
            User = user;
            Proyect = proyect;
            TaskStatus = taskStatus;
        }
    }
}
