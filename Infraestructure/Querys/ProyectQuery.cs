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
           var listProyects = await _context.Proyects.ToListAsync();
            return listProyects;
        }
    }
}
