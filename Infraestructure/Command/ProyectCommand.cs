using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Command
{
    public class ProyectCommand :IProyectCommand
    {
        private readonly AppDbContext _context;

        public ProyectCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task GetAllProyects()
        {
            await _context.Proyects.ToListAsync();
        }
    }
}
