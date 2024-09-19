using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateProyectDTO
    {
        public string Name { get; set; }  
        public Guid ClientID { get; set; }  
        public int CampaignType { get; set; }  
        public DateTime StartDate { get; set; }  
        public DateTime EndDate { get; set; }   
    }
}
