using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InterationTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Interactions> Interactions { get; set; }
        public InterationTypes()
        {
            
        }
        public InterationTypes(int id,string name)
        {
            this.Id = id;
            this.Name = name;
            this.Interactions = new List<Interactions>();
        }
    }
}
