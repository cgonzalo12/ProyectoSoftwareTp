using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Querys
{
    public class CampaignTypesQuery :ICampaignTypesQuery
    {
        public readonly AppDbContext _context;

        public CampaignTypesQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<CampaingTypes>> GetAllCampaingTypes()
        {
            var listCampaignTypes = await _context.CampaingTypes.ToListAsync();
            return listCampaignTypes;
        }
    }
}
