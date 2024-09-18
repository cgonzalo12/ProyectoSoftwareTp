using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Command
{
    public class InteractionTypeCommand :IInteractionTypeCommand
    {
        private readonly AppDbContext _context;
        public InteractionTypeCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task GetAllInteractionType()
        {
            await _context.InterationTypes.ToListAsync();
        }
    }
}
