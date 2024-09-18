using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Users
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Tasks> Tasks { get; set; }

        public Users()
        {
            
        }
        public Users(int id,string name,string email)
        {
            this.UserID = id;
            this.Name = name;
            this.Email = email;
            this.Tasks = new List<Tasks>();
        }
    }
}
