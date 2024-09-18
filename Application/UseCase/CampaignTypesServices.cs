using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class CampaignTypesServices : ICampaignTypeServices
    {
        
        private readonly ICampaignTypesQuery _query;

        public CampaignTypesServices(ICampaignTypesQuery query)
        {
           
            _query = query;
        }

        public async Task<List<CampaingTypes>> GetAllCampaingTypes()
        {
            return await _query.GetAllCampaingTypes();
        }
    }
}
