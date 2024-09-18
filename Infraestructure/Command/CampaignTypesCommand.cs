using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Command
{
    public class CampaignTypesCommand : ICampaignTypesCommand
    {
        private readonly AppDbContext _context;

        public CampaignTypesCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task GetAllCampaingTypes()
        {
            await _context.CampaingTypes.ToListAsync();
        }
    }
}
