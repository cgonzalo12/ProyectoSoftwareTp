using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Interactions
    {
        public Guid InteractionID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int InteractionType { get; set; }
        public Guid ProjectID { get; set; }
        public Proyects Proyect { get; set; }
        public InterationTypes InterationTypes { get; set; }

        public Interactions() { }
        public Interactions(Guid interactionID, DateTime date, string description, int interactionType, Guid projectID, Proyects proyect, InterationTypes interationTypes)
        {
            InteractionID = interactionID;
            Date = date;
            Description = description;
            InteractionType = interactionType;
            ProjectID = projectID;
            Proyect = proyect;
            InterationTypes = interationTypes;
        }
    }
}
