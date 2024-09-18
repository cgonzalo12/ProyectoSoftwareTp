using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CampaingTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Proyects> Proyects { get; set; }

        public CampaingTypes()
        {
            
        }
        public CampaingTypes(int id,string name)
        {
            this.Proyects = new List<Proyects>();
            this.Id = id;
            this.Name = name;
            
        }

    }
}
