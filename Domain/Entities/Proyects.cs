using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Proyects
    {
        public Guid ProjectID { get; set; }
        public string Name { get; set; }
        public Guid  ClientID { get; set; }
        public int CampaignType { get; set; }
        public DateTime StartDate { get; set; }  
        public DateTime EndDate { get; set; }
        public List<Tasks> Tasks { get; set; }
        public CampaingTypes CampaingTypes{ get; set; }
        public Clients Client { get; set; }
        public List<Interactions> Interactions { get; set; }

        public Proyects() { }
        public Proyects(Guid projectID, string name, Guid clientID, int campaignType, DateTime startDate, DateTime endDate, CampaingTypes campaingTypes, Clients client)
        {
            ProjectID = projectID; 
            Name = name;
            ClientID = clientID;
            CampaignType = campaignType;
            StartDate = startDate;
            EndDate = endDate;
            CampaingTypes = campaingTypes ?? throw new ArgumentNullException(nameof(campaingTypes)); 
            Client = client ?? throw new ArgumentNullException(nameof(client));
            Tasks = new List<Tasks>();
            Interactions = new List<Interactions>();
        }

    }
}
