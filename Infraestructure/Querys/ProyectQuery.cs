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
    public class ProyectQuery :IProyectQuery
    {
        public readonly AppDbContext _context;

        public ProyectQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Proyects>> GetAlProyects()
        {
           var listProyects = await _context.Proyects
                .Include(c=>c.Client)
                .ToListAsync();
            return listProyects;
        }

        public async Task<Proyects> GetProyect(string id)
        {
            if (Guid.TryParse(id, out var proyecID))
            {
                var proyect = await _context.Proyects.FirstOrDefaultAsync(p => p.ProjectID == proyecID);
                return proyect;
            }
            return null;
        }
    }
}
