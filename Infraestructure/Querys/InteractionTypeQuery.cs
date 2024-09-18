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
    public class InteractionTypeQuery : IInteractionTypeQuery
    {
        public readonly AppDbContext _context;

        public InteractionTypeQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<InterationTypes>> GetAllInteractionType()
        {
            var listInteractionType = await _context.InterationTypes.ToListAsync();
            return listInteractionType;
        }
    }
}
