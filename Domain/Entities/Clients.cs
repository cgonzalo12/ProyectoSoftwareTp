using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Clients
    {
        public Guid ClientID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Proyects> Proyects { get; set; }

        public Clients()
        {
            
        }
        public Clients(Guid clientID, string name, string email)
        {
            this.ClientID = clientID;
            this.Name = name;
            this.Email = email;
            this.Proyects = new List<Proyects>();
        }
    }
}
