using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TaskStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Tasks> Tasks { get; set; }

        public TaskStatus()
        {
            
        }
        public TaskStatus(int id,string name)
        {
            this.Id = id;
            this.Name = name;
            this.Tasks = new List<Tasks>();
        }
    }
}
